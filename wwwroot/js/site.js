﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function AgregarCampos_titulo(btn) {


    var table = document.getElementById("tablaC")
    var fila = table.getElementsByTagName('tr');

    var codigoFila = fila[fila.length - 1].outerHTML;

    var ultimafila = fila.length - 2 //document.getElementById("UltimoItem").value;
    var proximafila = eval(ultimafila) + 1;
    codigoFila = codigoFila.replaceAll('_' + ultimafila + '_', '_' + proximafila + '_');
    codigoFila = codigoFila.replaceAll('[' + ultimafila + ']', '[' + proximafila + ']');
    codigoFila = codigoFila.replaceAll('-' + ultimafila, '-' + proximafila);

    var nuevaFila = table.insertRow();
    nuevaFila.innerHTML = codigoFila;
}
//tbexplaboral
function Agregar_Campos_Experiencia_Laboral(btn) {


    var table = document.getElementById("tbexplaboral")
    var fila = table.getElementsByTagName('tr');

    var codigoFila = fila[fila.length - 1].outerHTML;

    var ultimafila = fila.length - 2 //document.getElementById("UltimoItem").value;
    var proximafila = eval(ultimafila) + 1;
    codigoFila = codigoFila.replaceAll('_' + ultimafila + '_', '_' + proximafila + '_');
    codigoFila = codigoFila.replaceAll('[' + ultimafila + ']', '[' + proximafila + ']');
    codigoFila = codigoFila.replaceAll('-' + ultimafila, '-' + proximafila);

    var nuevaFila = table.insertRow();
    nuevaFila.innerHTML = codigoFila;

}


function EliminarCamposFormacionAcademica(btn) {

    var tabla = document.getElementById('tablaC');
    var fila = tabla.getElementsByTagName('tr');

    if (fila.length == 2) {

        alert("Al menos debe tener un titulo");
        return;

    }

    var btnE = btn.id.replaceAll('btnremoveC-', '');
    var btnInput = btnE + "__EsEliminado";
    


    $(btn).closest('tr').hide();

}//tbexplaboral

function EliminarCamposExpeLaboral(btn) {

    var tabla = document.getElementById('tbexplaboral');
    var fila = tabla.getElementsByTagName('tr');

    if (fila.length == 2) {

        alert("Al menos debe tener un titulo");
        return;

    }

    var btnE = btn.id.replaceAll('btnremoveC-', '');
    var btnInput = btnE + "__EsEliminado";
    


    $(btn).closest('tr').hide();

}

