<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home1.aspx.cs" Inherits="ProjetoWebFacu.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Home</title>

     <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <script src="../Scripts/popper-utils.min.js"></script>

</head>
<body>

    <nav class="navbar navbar-dark bg-dark">
           <a class="navbar-brand" href="Home1.aspx">Início</a>
    </nav>

  <form class="container form-group">
    <table>
        <tr>
            <td>
                    <div class="card" style="width: 18rem;">
                      <img src="../Imagens/empresa.png" class="card-img-top"/>
                      <div class="card-body">
                        <h5 class="card-title">Empresas</h5>
                        <p class="card-text">Cadastre sua empresa e disponibilize seus carros para locação.</p>
                        <a href="#" class="btn btn-primary">Cadastrar minha Empresa</a>
                      </div>
                    </div>
            </td>
           
            
            <td>
                <br />
                  <br />
                  <br />
             
                <div class="card" style="width: 18rem;">
                      <img src="../Imagens/planilhaaa-gesto-de-frota-profissional-controle-de-veiculos-D_NQ_NP_706244-MLB32311719024_092019-F.jpg" class="card-img-top"/>
                      <div class="card-body">
                        <h5 class="card-title">Veiculos</h5>
                        <p class="card-text">Cadastre seus Veiculos e Tenha o controle de suas Frotas.</p>
                        <a href="#" class="btn btn-primary">Cadastrar Meus Veiculos</a>
                      </div>
                    </div>




            </td>
             <td>
                      <div class="card" style="width: 18rem;">
                      <img src="../Imagens/motorista.jpg" class="card-img-top"/>
                      <div class="card-body">
                        <h5 class="card-title">Motoristas</h5>
                        <p class="card-text">Cadastre todos seus motoristas e tenha um controle maior de suas locações.</p>
                        <a href="#" class="btn btn-primary">Cadastrar Motorista</a>
                      </div>
                    </div>
            </td>
       
        <td>
            <br />
            <br />
            <br />
            <br />

               <div class="card" style="width: 18rem;">
                      <img src="../Imagens/funcionarios.png" class="card-img-top"/>
                      <div class="card-body">
                        <h5 class="card-title">Funcionários</h5>
                        <p class="card-text">Cadastre seus funcionários e tenha o registro de toda sua equipe de tabalho.</p>
                        <a href="CadastroFuncionario.aspx" class="btn btn-primary">Cadastrar Funcionário</a>
                      </div>
                    </div>
            </td>
    </table>
 </form>
</body>
</html>
