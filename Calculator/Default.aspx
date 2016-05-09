<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Calculator" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Scientific Calculator</title>
    <link rel="shortcut icon" href="icon1.png" />
    <!--icon image -->
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="calc.css" />

</head>
<body >

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>

                <!--<div class="background">-->
                    
                   <!-- <img src="plain.jpg" id="bg_img" alt=" " /> -->

                    <div id="content">
                        <div class="container bg">
                            <!-- container -->


                            <div class="row">   <!-- First row -->
                              
                                <div class="col-md-6 col-md-offset-3">  <!-- First row, Column -->
                                    <br />
                        
                                    <p class="text-center">
                                        &nbsp;
                                    </p>
                                    
                                    <p class="text-center">
                                        &nbsp;
                                    </p>                       
                                    <h1 class="text-center">&nbsp;SCIENTIFIC CALCULATOR</h1>

                                    <!-- <asp:Panel ID="Panel2" runat="server"  class="img-responsive"> -->

                                </div>  <!-- First row, Column -->
                               
                                 </div><!--First Row Ends-->
                            

                                <div class="row"> <!--Second Row--> 
                                    <div class="col-md-6 col-md-offset-3"  style="border: solid 2px black;"> <!-- Second Row, Column-->
                                        <br />
                                       
                                        <asp:Label ID="labelCurrentOperation" class="center-block img-responsive" runat="server" Style="text-align: center"
                                            Height="16px" Width="1371px" ForeColor="#999999" EnableTheming="True"></asp:Label>                                  
                                        <br />
                                        <asp:TextBox ID="Screen" runat="server" BorderStyle="Solid" class="center-block img-responsive screen" Font-Size="X-Large" Height="34px" Style="text-align: right" Width="538px" ReadOnly="True">0</asp:TextBox>
                                        <br />
                                        <br />
                                        <div class="col-lg-6">

                                            <asp:Panel class="center-block" ID="Panel3" runat="server" Height="311px" Width="225px" ForeColor="#CCFFFF">
                                                <asp:Button ID="c_btn" runat="server" Height="36px" Text="C" Width="47px" ForeColor="Black" OnClick="c_btn_Click" />

                                                &nbsp;<asp:Button ID="del_btn" runat="server" ForeColor="Black" Height="36px" Text="CE" Width="47px" OnClick="del_btn_Click" />
                                                &nbsp;<asp:Button ID="percent_btn" runat="server" ForeColor="Black" Height="36px" Text="%" Width="47px" OnClick="percent_btn_Click" />
                                                &nbsp;<asp:Button ID="divide_btn" runat="server" ForeColor="Black" Height="36px" Text="÷" Width="47px" OnClick="operator_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="seven_btn" runat="server" ForeColor="Black" Height="36px" Text="7" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="eight_btn" runat="server" ForeColor="Black" Height="36px" Text="8" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="nine_btn" runat="server" ForeColor="Black" Height="36px" Text="9" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="multiply_btn" runat="server" ForeColor="Black" Height="36px" Text="×" Width="47px" OnClick="operator_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="four_btn" runat="server" ForeColor="Black" Height="36px" Text="4" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="five_btn" runat="server" ForeColor="Black" Height="36px" Text="5" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="six_btn" runat="server" ForeColor="Black" Height="36px" Text="6" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="subtract_btn" runat="server" ForeColor="Black" Height="36px" Text="-" Width="47px" OnClick="operator_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="one_btn" runat="server" ForeColor="Black" Height="36px" Text="1" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="two_btn" runat="server" ForeColor="Black" Height="36px" Text="2" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="three_btn" runat="server" ForeColor="Black" Height="36px" Text="3" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="add_btn" runat="server" ForeColor="Black" Height="36px" Text="+" Width="47px" OnClick="operator_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="zero_btn" runat="server" ForeColor="Black" Height="36px" Text="0" Width="47px" OnClick="button_click" />
                                                &nbsp;<asp:Button ID="decimal_btn" runat="server" ForeColor="Black" Height="36px" Text="." Width="47px" OnClick="button_click" />
                                                &nbsp;&nbsp;<asp:Button ID="eql_btn" runat="server" ForeColor="Black" Height="36px" Text="=" Width="102px" OnClick="eql_btn_Click" />
                                                &nbsp;
                                    <br />
                                                <br />
                                                &nbsp;&nbsp;
                                    <br />
                                                <br />
                                                &nbsp;&nbsp;&nbsp;<br />
                                                <br />
                                                &nbsp;&nbsp;&nbsp;<br />
                                                <br />
                                                &nbsp;&nbsp; &nbsp;&nbsp;<br />
                                                &nbsp;<br />
                                                &nbsp;
                                            </asp:Panel>

                                            &nbsp;
                                        </div>

                                        <div class="col-lg-6">

                                            <asp:Panel ID="Panel4" Class="center-block" runat="server" Height="294px" Width="222px" ForeColor="#CCFFFF">
                                                <asp:Button ID="Button112" runat="server" ForeColor="Black" Height="36px" Width="47px" Text="x²" OnClick="x_click" />
                                                &nbsp;<asp:Button ID="Button113" runat="server" ForeColor="Black" Height="36px" Width="47px" Text="x³" OnClick="x_click" />
                                                &nbsp;<asp:Button ID="Button114" runat="server" ForeColor="Black" Height="36px" Text="^" Width="47px" OnClick="operator_click" />
                                                &nbsp;<asp:Button ID="Button115" runat="server" ForeColor="Black" Height="36px" Text="10/x" Width="47px" OnClick="x_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="Button116" runat="server" ForeColor="Black" Height="36px" Text="√x" Width="47px" OnClick="x_click" />
                                                &nbsp;<asp:Button ID="Button117" runat="server" ForeColor="Black" Height="36px" Text="∛x" Width="47px" OnClick="x_click" />
                                                &nbsp;<asp:Button ID="factorial" runat="server" ForeColor="Black" Height="36px" Text="x!" Width="47px" OnClick="factorial_Click" />
                                                &nbsp;<asp:Button ID="Button118" runat="server" ForeColor="Black" Height="36px" OnClick="x_click" Text="1/x" Width="47px" />
                                                <br />
                                                <br />
                                                <asp:Button ID="sin_btn" runat="server" ForeColor="Black" Height="36px" Text="sin" Width="47px" OnClick="trig_click" />
                                                &nbsp;<asp:Button ID="cos_btn" runat="server" ForeColor="Black" Height="36px" Text="cos" Width="47px" OnClick="trig_click" />
                                                &nbsp;<asp:Button ID="tan_btn" runat="server" ForeColor="Black" Height="36px" Text="tan" Width="47px" OnClick="trig_click" />
                                                &nbsp;<asp:Button ID="Button123" runat="server" ForeColor="Black" Height="36px" Text="exp" Width="47px" OnClick="trig_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="sinh_btn" runat="server" ForeColor="Black" Height="36px" OnClick="trig_click" Text="sinh" Width="47px" />
                                                &nbsp;<asp:Button ID="cosh_btn" runat="server" ForeColor="Black" Height="36px" Text="cosh" Width="47px" OnClick="trig_click" />
                                                &nbsp;<asp:Button ID="tanh_btn" runat="server" ForeColor="Black" Height="36px" Text="tanh" Width="47px" OnClick="trig_click" />
                                                &nbsp;<asp:Button ID="ln_btn" runat="server" ForeColor="Black" Height="36px" Text="ln" Width="47px" OnClick="trig_click" />
                                                <br />
                                                <br />
                                                <asp:Button ID="Rand_btn" runat="server" ForeColor="Black" Height="36px" OnClick="Rand_btn_Click" Text="Rand" Width="99px" />
                                                &nbsp;&nbsp;<asp:Button ID="pi_btn" runat="server" ForeColor="Black" Height="36px" OnClick="pi_btn_Click" Text="π" Width="47px" />
                                                &nbsp;<asp:Button ID="e_btn" runat="server" ForeColor="Black" Height="36px" OnClick="e_btn_Click" Text="e" Width="47px" />
                                                &nbsp;
                                            </asp:Panel>

                                        </div>
                                        <br />

                                        <asp:Label ID="operationLabel" runat="server" Visible="False"></asp:Label>
                                        <asp:Label ID="resultLabel" runat="server" Visible="False">0</asp:Label>
                                        <asp:RadioButton ID="operationRadio" runat="server" Visible="False" />

                                        <asp:Label ID="trigLabel" runat="server" Visible="False"></asp:Label>

                                        <asp:Label ID="xLabel" runat="server" Visible="False"></asp:Label>
                                        <!-- </asp:Panel> -->

                                    </div> <!-- Second Row, Column-->
                                </div>   <!--Second row -->
                              



                           

                        </div>
                        <!-- container -->

                        <p>
                            &nbsp;
                        </p>

                    </div>
                    <!-- content -->


               <!-- </div>-->
                <!--Background-->

            </ContentTemplate>
        </asp:UpdatePanel>
    </form>


    <p>
        &nbsp;
    </p>


</body>
</html>


