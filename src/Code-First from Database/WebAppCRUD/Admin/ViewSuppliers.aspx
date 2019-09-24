<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewSuppliers.aspx.cs" Inherits="WebAppCRUD.Admin.ViewSuppliers" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="my" TagName="MessageUserControl" %>


<<<<<<< HEAD
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Suppliers</h1>
    <my:MessageUserControl runat="server" ID="MessageUserControl" />
    <asp:ListView ID="SupplierListView" runat="server"
        DataSourceID="SuppliersDataSource"
        InsertItemPosition="FirstItem"
        DataKeyNames="SupplierID"
=======
<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="my" TagName="MessageUserControl" %>  <%--Register Directive--%>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>View Suppliers</h1> 
<my:MessageUserControl runat="server" ID="MessageUserControl" />
    <asp:ListView ID="SupplierListView" runat="server"
        DataSourceID="SuppliersDataSource"
        InsertItemPosition="FirstItem"
        DataKeyNames="SupplierID" 
>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
        ItemType="WestWindSystem.Entities.Supplier">
        <LayoutTemplate>
            <table class="table table-hover table-condensed">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Company</th>
                        <th>Contact</th>
                        <th>Address</th>
                        <th>Phone / Fax</th>
                    </tr>
                </thead>
                <tbody>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </tbody>
            </table>
        </LayoutTemplate>

        <ItemTemplate>
            <tr>
                <td>
                    <asp:LinkButton ID="EditSupplier" runat="server"
                        CssClass="btn btn-info glyphicon glyphicon-pencil"
                        CommandName="Edit">
                        Edit
                    </asp:LinkButton>
                    <asp:LinkButton ID="Delete" runat="server"
                        CssClass="btn btn-danger"
                        OnClientClick="return confirm('Are you sure you want to delete this supplier?')"
                        CommandName="Delete">Delete</asp:LinkButton>
                </td>
                <td><%# Item.CompanyName %></td>
                <td>
                    <b><%# Item.ContactName %></b>
                    &ndash;
                    <i><%# Item.ContactTitle %></i>
                    <br />
                    <%# Item.Email %>
                </td>
                <td>
                    <%# Item.Address.Address1 %>
                    <br />
                    <%# Item.Address.City %>,
                    <%# Item.Address.Region %>
                    &nbsp;&nbsp;
                    <%# Item.Address.PostalCode %>
                    <br />
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
            <tr class="bg-info">
                <th>
                    <asp:LinkButton ID="AddSupplier" runat="server"
                        CssClass="btn btn-success glyphicon glyphicon-plus"
                        CommandName="Insert">
                        Add
                    </asp:LinkButton>
<<<<<<< HEAD
                    <asp:LinkButton ID="CancelInsert" runat="server" CssClass="btn btn-default" CommandName="Cancel">Clear</asp:LinkButton>

=======
                    <asp:LinkButton ID="CancelInsert" runat="server" CssClass="btn btn-default"
                        CommandName="Cancel">Clear</asp:LinkButton>
>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
                </th>
                <th><asp:TextBox ID="CompanyName" runat="server" Text="<%# BindItem.CompanyName %>" placeholder="Enter company name" /></th>
                <th>
                    <asp:TextBox ID="Contact" runat="server" Text="<%# BindItem.ContactName %>" placeholder="Contact name" />
                    <br />
                    <asp:TextBox ID="JobTitle" runat="server" Text="<%# BindItem.ContactTitle %>" placeholder="Job title" />
                    <br />
                    <asp:TextBox ID="Email" runat="server" Text="<%# BindItem.Email %>" TextMode="Email" placeholder="Email" />
                </th>
                <th>
                    <asp:DropDownList ID="AddressDropDown" runat="server"
                        DataSourceID="AddressDataSource"
                        AppendDataBoundItems="true"
                        DataTextField="Address1" DataValueField="AddressID"
                        SelectedValue="<%# BindItem.AddressID %>">
                        <asp:ListItem Value="">[Select address on file]</asp:ListItem>
                    </asp:DropDownList>
                </th>
                <th>
                    <asp:TextBox ID="Phone" runat="server" Text="<%# BindItem.Phone %>" TextMode="Phone" placeholder="Phone #" />
                    <br />
                    <asp:TextBox ID="Fax" runat="server" Text="<%# BindItem.Fax %>" TextMode="Phone" placeholder="Fax #" />
                </th>
            </tr>
        </InsertItemTemplate>

        <EditItemTemplate>
            <tr class="bg-success">
                <th>
                    <asp:LinkButton ID="UpdateSupplier" runat="server"
                        CssClass="btn btn-success glyphicon glyphicon-ok"
                        CommandName="Update">
                        Save
                    </asp:LinkButton>
<<<<<<< HEAD
                    <asp:LinkButton ID="CancelUpdate" runat="server" CssClass="btn btn-default" CommandName="Cancel">Cancel</asp:LinkButton>
=======
                    <asp:LinkButton ID="Delete" runat="server" CssClass="btn btn-danger"
                        OnClientClick="return confirm('Are you sure you want to delete this supplier?')"
                        CommandName="Delete">Delete</asp:LinkButton>
>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
                </th>
                <th><asp:TextBox ID="CompanyName" runat="server" Text="<%# BindItem.CompanyName %>" placeholder="Enter company name" /></th>
                <th>
                    <asp:TextBox ID="Contact" runat="server" Text="<%# BindItem.ContactName %>" placeholder="Contact name" />
                    <br />
                    <asp:TextBox ID="JobTitle" runat="server" Text="<%# BindItem.ContactTitle %>" placeholder="Job title" />
                    <br />
                    <asp:TextBox ID="Email" runat="server" Text="<%# BindItem.Email %>" TextMode="Email" placeholder="Email" />
                </th>
                <th>
                    <asp:DropDownList ID="AddressDropDown" runat="server"
                        DataSourceID="AddressDataSource"
                        AppendDataBoundItems="true"
                        DataTextField="Address1" DataValueField="AddressID"
                        SelectedValue="<%# BindItem.AddressID %>">
                        <asp:ListItem Value="">[Select address on file]</asp:ListItem>
                    </asp:DropDownList>
                </th>
                <th>
                    <asp:TextBox ID="Phone" runat="server" Text="<%# BindItem.Phone %>" TextMode="Phone" placeholder="Phone #" />
                    <br />
                    <asp:TextBox ID="Fax" runat="server" Text="<%# BindItem.Fax %>" TextMode="Phone" placeholder="Fax #" />
                </th>
            </tr>
        </EditItemTemplate>
    </asp:ListView>


<<<<<<< HEAD
    <asp:ObjectDataSource ID="SuppliersDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListSuppliers" TypeName="WestWindSystem.BLL.CRUDController" DataObjectTypeName="WestWindSystem.Entities.Supplier"
        OnInserted="CheckForExceptions"
        OnUpdated="CheckForExceptions"
        OnDeleted="CheckForExceptions"
        InsertMethod="AddSupplier" DeleteMethod="DeleteSupplier" UpdateMethod="UpdateSupplier"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="AddressDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListAddresses" TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>
=======
    <asp:ObjectDataSource ID="SuppliersDataSource" runat="server"
        OldValuesParameterFormatString="original_{0}" SelectMethod="ListSuppliers"
        TypeName="WestWindSystem.BLL.CRUDController" DataObjectTypeName="WestWindSystem.Entities.Supplier"
        InsertMethod="AddSupplier"
        OnInserted="CheckForExceptions"
        OnUpdated="CheckForExceptions"
        OnDeleted="CheckForExceptions"
        UpdateMethod="UpdateSupplier" DeleteMethod="DeleteSupplier"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="AddressDataSource" runat="server" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="ListAddresses" 
        TypeName="WestWindSystem.BLL.CRUDController"></asp:ObjectDataSource>

>>>>>>> 81c754166f71fe9effe0152abe310487fd806349
</asp:Content>
