<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AdminDash.Register" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <meta name="description" content=""/>
    <meta name="author" content=""/>

    <title>SB Admin 2 - Register</title>

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet"/>

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
    <div class="container">

        <div class="card o-hidden border-0 shadow-lg my-5">
            <div class="card-body p-0">
                <!-- Nested Row within Card Body -->
                <div class="row justify-content-between">
                    <div class="col-lg-12 bg-gradient-white">
                        <div class="p-5">
                            <div class="text-center">
                                <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                            </div>
                            <div class="user">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <asp:TextBox ID="exampleFirstName" CssClass="form-control form-control-user" placeholder="First Name" runat="server" required="true"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                        <asp:TextBox ID="exampleLastName" CssClass="form-control form-control-user" placeholder="Last Name" runat="server" required="true"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                     <asp:TextBox ID="exampleUsername" CssClass="form-control form-control-user" placeholder="Enter Username" runat="server" required="true"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                     <asp:TextBox ID="exampleInputPhone" CssClass="form-control form-control-user" placeholder="Contact No." TextMode="number" runat="server" required="true"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                     <asp:TextBox ID="exampleInputEmail" CssClass="form-control form-control-user" placeholder="Email Address" TextMode="Email" runat="server" CausesValidation="true"></asp:TextBox>
                                </div>

                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                     <asp:TextBox ID="exampleInputPassword" CssClass="form-control form-control-user" placeholder="Password" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-6">
                                     <asp:TextBox ID="exampleRepeatPassword" CssClass="form-control form-control-user" placeholder="Repeat Password" TextMode="Password" runat="server" required="true"></asp:TextBox>
                                    </div>
                                </div>
                                <asp:Label ID="labelError" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
                                <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary btn-user btn-block" OnClick="BtnRegister_Click"/>
                                <hr/>
                                <a href="index.html" class="btn btn-google btn-user btn-block">
                                    <i class="fab fa-google fa-fw"></i> Register with Google
                                </a>
                                <a href="index.html" class="btn btn-facebook btn-user btn-block">
                                    <i class="fab fa-facebook-f fa-fw"></i> Register with Facebook
                                </a>
                            </div>
                            <hr/>
                            <div class="text-center">
                                <a class="small" href="forgot-password.html">Forgot Password?</a>
                            </div>
                            <div class="text-center">
                                <a class="small" href="Login.aspx">Already have an account? Login!</a>
                            </div>
                            <br />
                            
                            <br /><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="js/sb-admin-2.min.js"></script>
    </form>
</body>
</html>
