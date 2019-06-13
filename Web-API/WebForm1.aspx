<%@ Page Language="C#" CodeBehind="WebForm1.aspx.cs" AutoEventWireup="true" Inherits="Web_API.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title>台北市托嬰中心</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <%--   <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>

            <div class="wrapper">
                <div class="table">

                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>
                            <div class="row header">
                                <div class="cell">
                                    郵遞區域
                                </div>
                                <div class="cell">
                                    地址
                                </div>
                                <div class="cell">
                                    電話
                                </div>
                                <div class="cell">
                                    負責人
                                </div>
                            </div>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <div class="row">
                                <div class="cell" data-title="Name">
                                    <%# Eval("DIVISION") %>
                                </div>
                                <div class="cell" data-title="Age">
                                    <%# Eval("ADDRESS") %>
                                </div>
                                <div class="cell" data-title="Occupation">
                                    <%# Eval("PHONE") %>
                                </div>
                                <div class="cell" data-title="Location">
                                    <%# Eval("CONTACT_NAME") %>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>

        </div>
    </form>
</body>
</html>
