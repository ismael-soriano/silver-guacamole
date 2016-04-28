<%@ Page Title="Index" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SilverGuacamoleWF.Customer.Index" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Index</h2>
    <p>
        <asp:LinkButton runat="server" href="Create">Create New</asp:LinkButton>

    </p>
    <p>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                <asp:HyperLinkField Text="Edit"
                    DataNavigateUrlFormatString="Edit.aspx?ID={0}"
                    DataNavigateUrlFields="Id" />
                <asp:HyperLinkField Text="Details"
                    DataNavigateUrlFormatString="Details.aspx?ID={0}"
                    DataNavigateUrlFields="Id" />
                <asp:HyperLinkField Text="Delete"
                    DataNavigateUrlFormatString="Delete.aspx?ID={0}"
                    DataNavigateUrlFields="Id" />
            </Columns>
        </asp:GridView>


    </p>
</asp:Content>
