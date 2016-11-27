jQuery(document).ready(function () {

    $("#m03EditarRutas").click(function (e) {

        alert("En Modificar")
        e.preventDefault();
        var url = '/gestion_ruta_comercial/ModificarRutasComerciales';
        var method = 'GET';
        var data = '';

        $.ajax(
            {
                url: url,
                type: method,
                data: data,
                success: function (data, textStatus, jqXHR) {

                    $("#contenido").empty();
                    $("#contenido").append(data);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
    });
});