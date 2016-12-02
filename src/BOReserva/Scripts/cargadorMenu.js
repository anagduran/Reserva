jQuery(document).ready(function () {

    $("#gestionAviones").click(function (e) {
        e.preventDefault();
        var url = '/gestion_aviones/M02_GestionAviones';
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

    $("#m08AgregarAutomovil").click(function (e) {
        alert("hola jeffrey");
        
        e.preventDefault();
        var url = '/gestion_automoviles/M08_AgregarAutomovil';
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

<<<<<<< HEAD
<<<<<<< HEAD
    $("#m03AgregarRuta").click(function (e) {
        e.preventDefault();
        var url = '/gestion_ruta_comercial/AgregarRutasComerciales';
=======
    $("#gestionUsuarios").click(function (e) {
        e.preventDefault();
        var url = '/gestion_usuarios/M12_Index';
>>>>>>> origin/M12_Usuarios_BO
=======
    $("#crearhotel").click(function (e) {
        e.preventDefault();
        var url = '/gestion_hoteles/M09_GestionHoteles_Crear';
>>>>>>> cb6653475b27a35524356aae489ae4bc9eaa5d60
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
<<<<<<< HEAD
<<<<<<< HEAD
    });


    $("#m03VisualizarRutas").click(function (e) {

        
        e.preventDefault();
        var url = '/gestion_ruta_comercial/VisualizarRutasComerciales';
=======
    });

    $("#modificarhotel").click(function (e) {
        e.preventDefault();
        var url = '/gestion_hoteles/M09_GestionHoteles_ModificarHotel';
>>>>>>> cb6653475b27a35524356aae489ae4bc9eaa5d60
        var method = 'GET';
        var data = '';

        $.ajax(
            {
                url: url,
                type: method,
                data: data,
                success: function (data, textStatus, jqXHR) {
<<<<<<< HEAD

=======
>>>>>>> cb6653475b27a35524356aae489ae4bc9eaa5d60
                    $("#contenido").empty();
                    $("#contenido").append(data);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
<<<<<<< HEAD
    });   


});
=======

=======
    });

    $("#desactivarhotel").click(function (e) {
        e.preventDefault();
        var url = '/gestion_hoteles/M09_GestionHoteles_Desactivar';
=======
    $("#gestionComida").click(function (e) {
        e.preventDefault();
        var url = '/gestion_comida_vuelo/M06_AgregarEditarComida';
>>>>>>> refs/remotes/origin/Develop
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
>>>>>>> cb6653475b27a35524356aae489ae4bc9eaa5d60
    });

});
>>>>>>> origin/M12_Usuarios_BO
