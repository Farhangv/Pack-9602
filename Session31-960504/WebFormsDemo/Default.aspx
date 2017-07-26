<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsDemo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 id="sitetitle" runat="server">ASP.NET</h1>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <button type="submit" class="btn btn-success btn-block" runat="server" id="mybtn" onserverclick="mybtn_ServerClick">ثبت</button>
        <p class="lead">ASP.NET is a free webGetting started framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
            <p>
                ASP.NET Web Forms lets you<a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a> build<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        &nbsp;dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
