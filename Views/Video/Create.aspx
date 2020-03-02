<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registrar video</title>

  <meta charset="UTF-8">
  <meta name="description" content="ASP.NET MVC 2 CRUD Video">
  <meta name="keywords" content="ASP.NET, MVC, Facpya">
  <meta name="author" content="Saul Alejandro Aguilar Caballero">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="../../Content/Site.css" rel="stylesheet" type="text/css" />


</head>
<body>
    <form action= "/Video/Create" method= "post">
    
    <fieldset>
    <Legend> Datos del Video</Legend>
    
    <label for= "idVideo">idVideo<label>
    <input type= "text" name="idVideo" /> 

    <label for= "titulo">titulo<label>
    <input type= "text" name="titlulo" /> 

    <label for= "repro">repro<label>
    <input type= "text" name="repro" /> 

    <label for= "url">url<label>
    <input type= "text" name="url" />
    
    <input type= "submit" value="Registrar"> 



</body>
</html>
