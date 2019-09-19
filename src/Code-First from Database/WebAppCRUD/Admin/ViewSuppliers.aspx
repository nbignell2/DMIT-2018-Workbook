﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ViewSuppliers.aspx.cs" Inherits="WebAppCRUD.Admin.ViewSuppliers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Suppliers</h1>

    <asp:ListView ID="SupplierListView" runat="server"
        DataSourceID="SuppliersDataSource" ItemType="WestWindSystem.Entities.Supplier">
        <layouttemplate>
            <table class="table table-hover table-condensed">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Company</th>
                        <th>Contact</th>
                        <th>Contact Title</th>
                        <th>Address</th>
                        <th>Phone</th>
                        <th>Fax</th>
                    </tr>
                </thead>
                <tbody>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </tbody>
            </table>
        </layouttemplate>

        <ItemTemplate>
            <tr>
                <td><%# Item.SupplierID %></td>
                <td><%# Item.CompanyName %></td>
                <td>
                    <b><%# Item.ContactName %></b>
                        &ndash;
                    <b><%# Item.ContactTitle %></b>
                    <br />
                    <b><%# Item.Email %></b>
                </td>
                <td>
                    <%# Item.Address.Address1 %>
                    <%# Item.Address.City %>
                    <%# Item.Address.Region %>
                    &nbsp;&nbsp;
                    <%# Item.Address.PostalCode %>
                    <%# Item.Address.Country %>
                </td>
                <td>
                    <%# Item.Phone %>
                    <br />
                    <%# Item.Fax %>
                </td>
            </tr>
        </ItemTemplate>

        <InsertItemTemplate>
            <tr>
                <th>
                    <asp:LinkButton ID="AddSupplier" runat="server" CssClass="btn btn-success glyphicon glyphicon-plus"
                        CommandName="Insert">Add</asp:LinkButton>
                </th>
                <th><asp:TextBox ID="CompanyName" runat="server" Text="<%# BindItem.CompanyName %>" placeholder="Enter company name"></asp:TextBox></th>
                <th>
                    <th><asp:TextBox ID="Contact" runat="server" Text="<%# BindItem.ContactName %>" placeholder="Contact name"></asp:TextBox></th>
                    <br />
                    <th><asp:TextBox ID="JobTitle" runat="server" Text="<%# BindItem.ContactTitle %>" placeholder="Job Title"></asp:TextBox></th>
                    <br />
                    <th><asp:TextBox ID="Email" runat="server" Text="<%# BindItem.Email %>" placeholder="Email"></asp:TextBox></th>
                    <br />
                </th>
                <th>Address</th>
                <th>
                    <th><asp:TextBox ID="Phone" runat="server" Text="<%# BindItem.Phone %>" placeholder="Phone Number"></asp:TextBox></th>
                    <br />
                    <th><asp:TextBox ID="Fax" runat="server" Text="<%# BindItem.Fax %>" placeholder="Fax Number"></asp:TextBox></th>
                    <br />
                </th>
            </tr>
        </InsertItemTemplate>
    </asp:ListView>

    <asp:ObjectDataSource ID="SuppliersDataSource" runat="server" OldValuesParameterFormatString="original_{0}"
        SelectMethod="ListSuppliers" TypeName="WestWindSystem.BLL.CRUDController"
        DataObjectTypeName="WestWindSystem.Entities.Supplier" InsertMethod="AddSupplier">
        </asp:ObjectDataSource>
</asp:Content>
