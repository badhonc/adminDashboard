<%@ Page Title="List of Users" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="UserList.aspx.cs" Inherits="AdminDash.UserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">

        <!-- Page Heading -->
        <h1 class="h3 mb-2 text-gray-800 text-center">All Users List</h1>

        <!-- DataTales Example -->
        <div class="card shadow mb-4">
            <div class="card-header py-3">
                <h6 class="m-0 font-weight-bold text-primary">Users Data</h6>
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <asp:GridView ID="GridView1" CssClass="table table-bordered table-striped w-100 dataTable1" AutoGenerateColumns="false"  runat="server">
                        <Columns>
                            <asp:BoundField DataField="Sl" HeaderText="Sl" />
                            <asp:BoundField DataField="Id" HeaderText="User ID" />
                            <asp:BoundField DataField="username" HeaderText="User Name" />
                            <asp:BoundField DataField="firstName" HeaderText="First Name" />
                            <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                            <asp:BoundField DataField="Name" HeaderText="Full Name" />
                            <asp:BoundField DataField="Contact_no" HeaderText="Contact No" /> 
                            <asp:BoundField DataField="Email" HeaderText="Email ID" />
                            
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
