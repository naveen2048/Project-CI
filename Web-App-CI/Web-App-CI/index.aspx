<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web_App_CI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <meta charset="utf-8" />
  <link href="Content/bootstrap.min.css" rel="stylesheet" />
  <script src="Scripts/jquery-1.10.2.min.js"></script>
  <script src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.7/angular.min.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    <nav class="navbar navbar-default navbar-inverse text-info">
      <div class="container-fluid">
        <div class="navbar-header">
          <a class="navbar-brand" href="#">WebSiteName</a>
        </div>
      </div>
    </nav>
    <div class="container">
      <div class="panel panel-default">
        <div class="panel-heading">
          Countries List
        </div>
        <div class="panel-body">
          <asp:GridView ID="grd" runat="server" AutoGenerateColumns="true" CssClass="table table-responsive">
            <HeaderStyle CssClass="text-primary" />
          </asp:GridView>
        </div>

      </div>
    </div>
    <div class="navbar-fixed-bottom navbar-inverse">
      <div class="text-info">
        Some Inc.
      </div>
    </div>
  </form>
</body>
</html>
