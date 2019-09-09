<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VotePage.aspx.cs" Inherits="votes.VotePage" %>

<!DOCTYPE html>
<html lang="en">
<title>בחירות 2019 רמון</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<style>
.button5 {
  background-color: white;
  color: black;
  border: 2px solid #555555;
     direction: rtl;
}

.button5:hover {
  background-color: #555555;
  color: white;
}
</style>
<body style="background-color:lightgray;">
    <form id="form1" runat="server">
<%--<div class="w3-container w3-top w3-white w3-xlarge w3-padding-16">
  
<!-- Top menu on small screens -->
    
 
</div>--%>
        <header><p style="background-color:white; font-size:xx-large;">בחירות 2019

  
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

  
            </p></header>

<!-- Manager Button -->
    <%if (Session["Manager"].ToString() == "yes")
        {%>
  
    <% }%>
<!-- Overlay effect when opening sidebar on small screens -->


<!-- !PAGE CONTENT! -->

  
  <!-- Photo grid -->
 
      
        <asp:ImageButton ID="ImageButton1" runat="server"   ImageUrl="מפלגות%202.0/Screenshot_1.png" OnClick="ImageButton_Click" CommandArgument="1"/>
        <asp:ImageButton ID="ImageButton2" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_2.png" OnClick="ImageButton_Click" CommandArgument="2"/>
        <asp:ImageButton ID="ImageButton3" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_3.png" OnClick="ImageButton_Click" CommandArgument="3"/>
        <asp:ImageButton ID="ImageButton13" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_4.png" OnClick="ImageButton_Click" CommandArgument="4"/>
        <asp:ImageButton ID="ImageButton14" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_5.png" OnClick="ImageButton_Click" CommandArgument="5"/>
        <asp:ImageButton ID="ImageButton16" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_7.png" OnClick="ImageButton_Click" CommandArgument="6"/>
        <asp:ImageButton ID="ImageButton17" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_8.png" OnClick="ImageButton_Click" CommandArgument="7"/>
      
  
    

    

      
        <asp:ImageButton ID="ImageButton4" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_9.png" OnClick="ImageButton_Click" CommandArgument="8"/>
        <asp:ImageButton ID="ImageButton5" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_10.png"  OnClick="ImageButton_Click" CommandArgument="9"/>
        <asp:ImageButton ID="ImageButton6" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_11.png" OnClick="ImageButton_Click" CommandArgument="10"/>
        <asp:ImageButton ID="ImageButton18" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_12.png" OnClick="ImageButton_Click" CommandArgument="11"/>
        <asp:ImageButton ID="ImageButton19" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_13.png"  OnClick="ImageButton_Click" CommandArgument="12"/>
        <asp:ImageButton ID="ImageButton20" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_14.png"  OnClick="ImageButton_Click" CommandArgument="13"/>
        <asp:ImageButton ID="ImageButton21" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_15.png" OnClick="ImageButton_Click" CommandArgument="14"/>
        <asp:ImageButton ID="ImageButton22" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_16.png"  OnClick="ImageButton_Click" CommandArgument="15"/>
      

    

  
      
        <asp:ImageButton ID="ImageButton7" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_17.png"  OnClick="ImageButton_Click" CommandArgument="16"/>
        <asp:ImageButton ID="ImageButton8" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_18.png" OnClick="ImageButton_Click" CommandArgument="17"/>
        <asp:ImageButton ID="ImageButton9" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_19.png"  OnClick="ImageButton_Click" CommandArgument="18"/>
        <asp:ImageButton ID="ImageButton23" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_20.png" OnClick="ImageButton_Click" CommandArgument="19"/>
        <asp:ImageButton ID="ImageButton24" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_21.png"  OnClick="ImageButton_Click" CommandArgument="20"/>
        <asp:ImageButton ID="ImageButton25" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_22.png"  OnClick="ImageButton_Click" CommandArgument="21"/>
        <asp:ImageButton ID="ImageButton26" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_23.png"  OnClick="ImageButton_Click" CommandArgument="22"/>
        <asp:ImageButton ID="ImageButton27" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_24.png" OnClick="ImageButton_Click" CommandArgument="23"/>
      
  
      
        <asp:ImageButton ID="ImageButton10" runat="server"    ImageUrl="~/מפלגות 2.0/Screenshot_25.png"  OnClick="ImageButton_Click" CommandArgument="24"/>
        <asp:ImageButton ID="ImageButton11" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_26.png" OnClick="ImageButton_Click" CommandArgument="25"/>
        <asp:ImageButton ID="ImageButton12" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_27.png"  OnClick="ImageButton_Click" CommandArgument="26"/>
        <asp:ImageButton ID="ImageButton28" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_28.png" OnClick="ImageButton_Click" CommandArgument="27"/>
        <asp:ImageButton ID="ImageButton29" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_29.png"  OnClick="ImageButton_Click" CommandArgument="28"/>
        <asp:ImageButton ID="ImageButton30" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_30.png"  OnClick="ImageButton_Click" CommandArgument="29"/>
        <asp:ImageButton ID="ImageButton31" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_31.png"  OnClick="ImageButton_Click" CommandArgument="30"/>
        <asp:ImageButton ID="ImageButton32" runat="server"   ImageUrl="~/מפלגות 2.0/Screenshot_32.png" OnClick="ImageButton_Click" CommandArgument="31"/>
      
  
  


  

<!-- End page content -->





    </form>




</body>
</html>
