﻿<%@ Page Title="" Language="C#" MasterPageFile="~/view/RESFOM07/RESFOM7.Master" AutoEventWireup="true" CodeBehind="listar-habitaciones.aspx.cs" Inherits="frontoffice.view.RESFOM07.listar_habitaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Estilos" runat="server">    
    <link href="../assets/css/layout-datatables.css" rel="stylesheet" type="text/css" />
    <link href="css/global.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-md-12 col-sm-12">
            <h2 class="color-azul">Hotel _________ : Lista de Habitaciones</h2>
        </div>        
    </div>
    <!-- HTML DATATABLES -->
    <table class="table table-striped table-bordered table-hover" id="sample_1">
        <thead>
            <tr>
                <th>Codigo</th>
                <th>Piso</th>                
                <th>Descuento</th>
                <th>Estato</th>                
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><a href="detalle-habitacion.aspx">H5-030A</a></td>
                <td>0</td>
                <td><span class="label label-success">20%</span></td>
                <td><span class="label label-success">Disposible</span></td>
            </tr>
            <tr>
                <td><a href="detalle-habitacion.aspx">H5-030A</a></td>
                <td>0</td>
                <td><span class="label label-success">20%</span></td>
                <td><span class="label label-success">Disposible</span></td>                
            </tr>
            <tr>
                <td><a href="detalle-habitacion.aspx">H5-030A</a></td>
                <td>0</td>
                <td><span class="label label-success">20%</span></td>
                <td><span class="label label-danger">Ocupada</span></td>                
            </tr>
            <tr>
                <td><a href="detalle-habitacion.aspx">H5-030A</a></td>
                <td>0</td>
                <td><span class="label label-success">20%</span></td>
                <td><span class="label label-default">Cerrada</span></td>
            </tr>
            <tr>
                <td><a href="detalle-habitacion.aspx">H5-030A</a></td>
                <td>0</td>
                <td><span class="label label-success">20%</span></td>
                <td><span class="label label-default">Cerrada</span></td>
            </tr>
        </tbody>
    </table>    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Codigo" runat="server">
    <!-- JS DATATABLES -->
    <script type="text/javascript" src="../assets/plugins/datatables/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="../assets/plugins/datatables/js/dataTables.tableTools.min.js"></script>
    <script type="text/javascript" src="../assets/plugins/datatables/js/dataTables.colReorder.min.js"></script>
    <script type="text/javascript" src="../assets/plugins/datatables/js/dataTables.scroller.min.js"></script>
    <script type="text/javascript" src="../assets/plugins/datatables/dataTables.bootstrap.js"></script>
    <script type="text/javascript" src="../assets/plugins/select2/js/select2.full.min.js"></script>
    <script type="text/javascript">

        function initTable1() {
            var table = jQuery('#sample_1');

            /* Table tools samples: https://www.datatables.net/release-datatables/extras/TableTools/ */

            /* Set tabletools buttons and button container */

            $.extend(true, $.fn.DataTable.TableTools.classes, {
                "container": "btn-group",
                "buttons": {
                    "normal": "btn btn-sm btn-default",
                    "disabled": "btn btn-sm btn-default disabled"
                },
                "collection": {
                    "container": "DTTT_dropdown dropdown-menu tabletools-dropdown-menu"
                }
            });

            var oTable = table.dataTable({
                "order": [
                    [0, 'asc']
                ],

                "lengthMenu": [
                    [5, 15, 20, -1],
                    [5, 15, 20, "All"] // change per page values here
                ],
                // set the initial value
                "pageLength": 10,

                "dom": "<'row'<'col-md-4 col-sm-12'l><'col-md-4 col-sm-12 centrado'T><'col-md-4 col-sm-12'f>r><'table-scrollable't><'row'<'col-md-5 col-sm-12'i><'col-md-7 col-sm-12'p>>", // horizobtal scrollable datatable

                "tableTools": {
                    "sSwfPath": "../assets/plugins/datatables/extensions/TableTools/swf/copy_csv_xls_pdf.swf",
                    "aButtons": [{
                        "sExtends": "pdf",
                        "sButtonText": "PDF"
                    }, {
                        "sExtends": "csv",
                        "sButtonText": "CSV"
                    }, {
                        "sExtends": "xls",
                        "sButtonText": "Excel"
                    }, {
                        "sExtends": "print",
                        "sButtonText": "Print",
                        "sInfo": 'Please press "CTR+P" to print or "ESC" to quit',
                        "sMessage": "Generated by DataTables"
                    }]
                }
            });

            var tableWrapper = jQuery('#sample_1_wrapper'); // datatable creates the table wrapper by adding with id {your_table_jd}_wrapper

            tableWrapper.find('.dataTables_length select').select2(); // initialize select2 dropdown
        }

        // Table Init
        initTable1();
    </script>
</asp:Content>


