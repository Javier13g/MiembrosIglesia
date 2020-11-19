function Ocultar() {
    document.getElementById('').style.display = 'none';
}

function MostrarDatosPersonales() {
    document.getElementById('DatosPersonales').style.display = 'block';
    document.getElementById('DatosFamiliares').style.display = 'none';
    document.getElementById('DatosLaborales').style.display = 'none';
    document.getElementById('DatosEclesiasticos').style.display = 'none';
    document.getElementById('DatosAcademicos').style.display = 'none';
}

function MostrarDatosFamiliares() {
    document.getElementById('DatosFamiliares').style.display = 'block';
    document.getElementById('DatosPersonales').style.display = 'none';
    document.getElementById('DatosLaborales').style.display = 'none';
    document.getElementById('DatosEclesiasticos').style.display = 'none';
    document.getElementById('DatosAcademicos').style.display = 'none';
}

function MostrarDatosLaborales() {
    document.getElementById('DatosFamiliares').style.display = 'none';
    document.getElementById('DatosEclesiasticos').style.display = 'none';
    document.getElementById('DatosPersonales').style.display = 'none';
    document.getElementById('DatosLaborales').style.display = 'block';
    document.getElementById('DatosAcademicos').style.display = 'none';
}

function MostrarDatosEclesiasticos() {
    document.getElementById('DatosFamiliares').style.display = 'none';
    document.getElementById('DatosEclesiasticos').style.display = 'block';
    document.getElementById('DatosPersonales').style.display = 'none';
    document.getElementById('DatosLaborales').style.display = 'none';
    document.getElementById('DatosAcademicos').style.display = 'none';
}

function MostrarDatosAcademicos() {
    document.getElementById('DatosFamiliares').style.display = 'none';
    document.getElementById('DatosEclesiasticos').style.display = 'none';
    document.getElementById('DatosPersonales').style.display = 'none';
    document.getElementById('DatosLaborales').style.display = 'none';
    document.getElementById('DatosAcademicos').style.display = 'block';
}

function Mostrar2() {
    document.getElementById('test3').style.display = 'block';
}

function MostrarInputCiudad()
{
    document.getElementById('ciudadNacimiento').style.display = 'block';
}
function MostrarInputCiudadActual()
{
    document.getElementById('ciudadActual').style.display = 'block';
}

function MostrarDocumentoID()
{
    document.getElementById('documentoID').style.display = 'block';
}

function MostrarInputConyugue()
{
    document.getElementById('MostrarConyugue').style.display = 'block';
}

function MostrarInputHijos()
{
    document.getElementById('MostrarHijos').style.display = 'block';
}

function MostrarInputDenominacion()
{
    document.getElementById('MostrarDenominacion').style.display = 'block';
}

function MostrarInputDisciplina()
{
    document.getElementById('MostrarDisciplina').style.display = 'block';
    
}

function MostrarInputCausas()
{
    document.getElementById('MostrarCausas').style.display = 'block';
}

function MostrarDetallesPersonales()
{
    document.getElementById('DetallesPersonales').style = 'block'
    document.getElementById('DetallesFamiliares').style = 'none'
}

function MostrarDetallesFamiliares()
{
    document.getElementById('DetallesPersonales').style = 'none'
    document.getElementById('DetallesFamiliares').style = 'block'
}

function AlertBorrarMiembros() {
    
    alertify.alert('Exito', function () { alertify.success('Registro Eliminado'); });

}

function AlertGuardarMiembros() {
    alertify.alert('Aviso!!!','Exito!', function () { alertify.success('Registro Guardado'); });

}



