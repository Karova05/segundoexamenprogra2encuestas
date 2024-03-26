<%@ Page Title="" Language="C#" MasterPageFile="~/menuencuesta.Master" AutoEventWireup="true" CodeBehind="encuestas.aspx.cs" Inherits="segundoexamenprogra2encuentas.encuestas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="auto-style1">
    
    <h1 class="text-center"> <b> ingrese sus datos </b></h1>

        <div class="text-center">

    <br />
    <br />
            <br />

        </div>

        <div >
    
            numero de encuesta

            <br />
    <br />

            nombre

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <br />
    <br />

            apellido

            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <br />
    <br />


            fecha de nacimiento

            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            <br />
    <br />


            correo electronico

            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            <br />
    <br />


            carro propio 

                <asp:RadioButton ID="rbutton1" runat="server" Text="si" />    <asp:RadioButton ID="rbutton2" runat="server" Text="no" />

            
            <br />
    <br />
            <br />
    <br />
            <br />
    <br />

            <asp:Button ID="tingresar" runat="server" Text="ingresar" OnClick="tingresar_Click" />

            <br />
    <br />


        </div>
        


    </div>

</asp:Content>
