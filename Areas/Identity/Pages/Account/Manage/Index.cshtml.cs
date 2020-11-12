using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiembrosIglesia.Data;

namespace MiembrosIglesia.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Usuarios> _userManager;
        private readonly SignInManager<Usuarios> _signInManager;

        public IndexModel(
            UserManager<Usuarios> userManager,
            SignInManager<Usuarios> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Nombre completo")]
            public string Name { get; set; }

            [Display(Name = "Color favorito")]
            public string Color { get; set; }
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(Usuarios user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var _User = await _userManager.GetUserAsync(User);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Name = _User.Nombre_Usuario,
                Color = _User.Color_Usuario,
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            var _user = await _userManager.GetUserAsync(User);
            bool ATG = false;
            if (Input.Name != _user.Nombre_Usuario)
            {
                _user.Nombre_Usuario = Input.Name;
                ATG = true;
            }

            if (Input.Color != _user.Color_Usuario)
            {
                _user.Color_Usuario = Input.Color;
                ATG = true;
            }

            if (ATG)
            {
                await _userManager.UpdateAsync(_user);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Informacion del perfil actualizada";
            return RedirectToPage();
        }
    }
}
