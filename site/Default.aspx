<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="site.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 189px;
        }
        .auto-style4 {
            width: 279px;
        }
        .auto-style5 {
            width: 365px;
        }
        .auto-style6 {
            margin-left: 346px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="M_ID" DataSourceID="MalzemeDB" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="M_ID" HeaderText="M_ID" InsertVisible="False" ReadOnly="True" SortExpression="M_ID" />
                    <asp:CheckBoxField DataField="Aktif" HeaderText="Aktif" SortExpression="Aktif" />
                    <asp:BoundField DataField="MalzemeKodu" HeaderText="MalzemeKodu" SortExpression="MalzemeKodu" />
                    <asp:BoundField DataField="MalzemeAdi" HeaderText="MalzemeAdi" SortExpression="MalzemeAdi" />
                    <asp:BoundField DataField="OzelKod" HeaderText="OzelKod" SortExpression="OzelKod" />
                    <asp:BoundField DataField="KDV" HeaderText="KDV" SortExpression="KDV" />
                    <asp:BoundField DataField="B_ID" HeaderText="B_ID" SortExpression="B_ID" />
                    <asp:BoundField DataField="OlusturmaTarihi" HeaderText="OlusturmaTarihi" SortExpression="OlusturmaTarihi" />
                    <asp:BoundField DataField="DüzenlemeTarihi" HeaderText="DüzenlemeTarihi" SortExpression="DüzenlemeTarihi" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="MalzemeDB" runat="server" ConnectionString="<%$ ConnectionStrings:ProjeStajConnectionString7 %>" DeleteCommand="DELETE FROM [Malzemeler] WHERE [M_ID] = @M_ID" InsertCommand="INSERT INTO [Malzemeler] ([Aktif], [MalzemeKodu], [MalzemeAdi], [OzelKod], [KDV], [B_ID], [OlusturmaTarihi], [DüzenlemeTarihi]) VALUES (@Aktif, @MalzemeKodu, @MalzemeAdi, @OzelKod, @KDV, @B_ID, @OlusturmaTarihi, @DüzenlemeTarihi)" SelectCommand="SELECT * FROM [Malzemeler]" UpdateCommand="UPDATE [Malzemeler] SET [Aktif] = @Aktif, [MalzemeKodu] = @MalzemeKodu, [MalzemeAdi] = @MalzemeAdi, [OzelKod] = @OzelKod, [KDV] = @KDV, [B_ID] = @B_ID, [OlusturmaTarihi] = @OlusturmaTarihi, [DüzenlemeTarihi] = @DüzenlemeTarihi WHERE [M_ID] = @M_ID">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="hdfMalzemeId" Name="M_ID" PropertyName="Value" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="cbaktif" Name="Aktif" PropertyName="Checked" Type="Boolean" />
                    <asp:ControlParameter ControlID="ddlkod" Name="MalzemeKodu" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="ddlad" Name="MalzemeAdi" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="ddlozelkod" Name="OzelKod" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="txtkdv" Name="KDV" PropertyName="Text" Type="Double" />
                    <asp:ControlParameter ControlID="hdfBirimId" Name="B_ID" PropertyName="Value" Type="Int32" />
                    <asp:ControlParameter ControlID="txtot" DbType="Date" Name="OlusturmaTarihi" PropertyName="Text" />
                    <asp:ControlParameter ControlID="txtdt" DbType="Date" Name="DüzenlemeTarihi" PropertyName="Text" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="cbaktif" Name="Aktif" PropertyName="Checked" Type="Boolean" />
                    <asp:ControlParameter ControlID="ddlkod" Name="MalzemeKodu" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="ddlad" Name="MalzemeAdi" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="ddlozelkod" Name="OzelKod" PropertyName="SelectedValue" Type="String" />
                    <asp:ControlParameter ControlID="txtkdv" Name="KDV" PropertyName="Text" Type="Double" />
                    <asp:ControlParameter ControlID="hdfBirimId" Name="B_ID" PropertyName="Value" Type="Int32" />
                    <asp:ControlParameter ControlID="txtot" DbType="Date" Name="OlusturmaTarihi" PropertyName="Text" />
                    <asp:ControlParameter ControlID="txtkdv" DbType="Date" Name="DüzenlemeTarihi" PropertyName="Text" />
                    <asp:ControlParameter ControlID="hdfMalzemeId" Name="M_ID" PropertyName="Value" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:HiddenField ID="hdfMalzemeId" runat="server" />
            <asp:HiddenField ID="hdfBirimId" runat="server" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Malzeme Kodu</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlkod" runat="server" DataSourceID="MalzemeDB" DataTextField="MalzemeKodu" DataValueField="MalzemeKodu" Width="144px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">Düzenlenme Tarihi</td>
                    <td>
                        <asp:TextBox ID="txtdt" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Malzeme Adı</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlad" runat="server" DataSourceID="MalzemeDB" DataTextField="MalzemeAdi" DataValueField="MalzemeAdi" Height="19px" Width="144px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">Oluşturma Tarihi</td>
                    <td>
                        <asp:TextBox ID="txtot" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Özel Kod</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="ddlozelkod" runat="server" DataSourceID="MalzemeDB" DataTextField="OzelKod" DataValueField="OzelKod" Height="19px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" Width="144px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">Aktif</td>
                    <td>
                        <asp:CheckBox ID="cbaktif" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">KDV</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtkdv" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
        <asp:Button ID="bekle" runat="server" CssClass="auto-style6" OnClick="bekle_Click" Text="Ekle" />
        <asp:Button ID="bguncelle" runat="server" OnClick="bguncelle_Click" Text="Güncelle" />
        <asp:Button ID="bsil" runat="server" OnClick="bsil_Click" Text="Sil" />
        <asp:Label ID="lblmesaj" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    </form>
</body>
</html>
