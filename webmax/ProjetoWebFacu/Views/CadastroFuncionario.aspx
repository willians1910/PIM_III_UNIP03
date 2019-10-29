﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroFuncionario.aspx.cs" Inherits="ProjetoWebFacu.CadastroFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Cadastro de Funcionários</title>

     <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper-utils.min.js"></script>

</head>
<body>

    <nav class="navbar navbar-dark bg-dark">
           <a class="navbar-brand" href="Home1.aspx">Início</a>
    </nav>
    <br />
  
    <center><h3>Cadastro de Funcionarios!</h3></center>

   
   
    <form runat="server" class="container form-group">
 <div class="jumbotron">

         <table class="container form-group">
             <tr>
                 <td>
      
        <div  class="container form-group">
            
           
            <asp:Label ID="CpfLabel" runat="server" Text="CPF:"></asp:Label>
            <asp:TextBox ID="cpfTextBox" runat="server"></asp:TextBox>
            </div>
             </td>
               <td>
        <div  class="container form-group">
            <asp:Label ID="RgLabel" runat="server" Text="RG:"></asp:Label>
            <asp:TextBox ID="RgTextBox" runat="server"></asp:TextBox>
            </div>
            </td>
                 <td>
        <div  class="container form-group">
            <asp:Label ID="NomeLabel" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="NomeTextBox" runat="server"></asp:TextBox>
            </div>
            </td>
             <td>
        <div  class="container form-group">
            <asp:Label ID="SexoLabel" runat="server" Text="Sexo: (M / F)"></asp:Label>
            <asp:TextBox ID="SexoTextBox" runat="server" Width="52px"></asp:TextBox>
             </td>
             </tr> 
            
             </table>
      

        </div>  
        

         
        <center><h5>Endereço:</h5></center>
        <br />

        <div class="jumbotron">
        <table class="container form-group">
            <tr>
                <td>
        <div  class="container form-group">
        <asp:Label ID="LogradouraLabel" runat="server" Text="Logradoura (Rua):"></asp:Label>
            <asp:TextBox ID="LogradouraTextBox" runat="server"></asp:TextBox>

            </div>

               </td>

           <td>

        <div  class="container form-group">
            <asp:Label ID="NumeroLabel" runat="server" Text="Numero:"></asp:Label>
            <asp:TextBox ID="NumeroTextBox" runat="server"></asp:TextBox>
            </div>
           </td>
            <td>
        <div  class="container form-group">
            <asp:Label ID="ComprimentoLabel" runat="server" Text="Comprimento:"></asp:Label>
            <asp:TextBox ID="ComprimentoTextBox" runat="server"></asp:TextBox>
            </div>
                </td>
             
            <td>
        <div  class="container form-group">
            <asp:Label ID="BairroLabel" runat="server" Text="Bairro:"></asp:Label>
            <asp:TextBox ID="BairroTextBox" runat="server"></asp:TextBox>
            </div>
            </td>
            </tr>
            </table>
            </div>
        
        <center><h5>Telefone:</h5></center>
        <br />

        <div class="jumbotron">
         <table class="container form-group">
            <tr>
          <td> 
                <div  class="container form-group">
                 <asp:Label ID="DdLabel" runat="server" Text="DD:"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
        </td> 
         <td> 
        <div  class="container form-group">
            <asp:Label ID="DddLabel" runat="server" Text="DDD:"></asp:Label>
            <asp:TextBox ID="DddTextBox2" runat="server"></asp:TextBox>
            </div>
              </td> 
              <td> 
        <div  class="container form-group">
            <asp:Label ID="TelefoneLabel" runat="server" Text="Telefone:"></asp:Label>
            <asp:TextBox ID="TelefoneTextBox" runat="server"></asp:TextBox>
               </div>
              </td>

             </tr>
             </table>

        </div>   
        <center><h5>Perfil:</h5></center>
        <br />

        <div class="jumbotron">
        <table class="container form-group">
            <tr>
                <td>
        <div  class="container form-group">
        <asp:Label ID="CargoLabel" runat="server" Text="Cargo:"></asp:Label>
            <asp:TextBox ID="CargoTextBox" runat="server"></asp:TextBox>
            
            </div>
               </td>
           <td>
        <div  class="container form-group">
            <asp:Label ID="SalarioLabel" runat="server" Text="Salario:"></asp:Label>
            <asp:TextBox ID="SalarioTextBox" runat="server"></asp:TextBox>
            </div>
           </td>
                 </table>
             
                </div>
     
       <center><asp:Button ID="salvarButton1" class="btn btn-success" runat="server" Text="Salvar (^_^)"/></center>
          
        </form>
    </body>
</html>