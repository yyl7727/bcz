<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="list.aspx.cs" Inherits="百词斩.list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

 <style type="text/css">
               #top_right {
            float: right;
            height:50px;         
            margin:5px 250px 0px 0px;
        }
        #top_right ul a {
            padding: 0;
            margin: 0 0 10px 0;
            text-decoration: none;
        }
        #top_right ul {
            z-index: 100;
            margin: 0;
            padding: 0;           
            list-style-type: none;
        }
        #top_right ul li {
            position: relative;
            display: inline;
            float: left;
       }
       #top_right ul li a {
                display: block;
                padding: 0 30px;
                height: 40px;
                line-height: 40px;
                font-size: 15px;
                color:black;
                text-decoration: none;
                outline: none;
                text-align: center;
                border-radius:10px;
       }
        #top_right ul li a.selected, #top_right ul li a:hover {
            color:#eb8a8a;
            background-color:powderblue;
        }
            #top_right ul li ul li a.selected, #top_right ul li ul li a:hover {
                color: black;
                font-weight: 700;
                background: white;
            }
            #top_right ul li ul {
                position: absolute;
                display: none;
                left: 0;
                visibility: hidden;
                background: white;
                padding: 10px 0 0;
                border-bottom: 4px solid #000;
            }
            #top_right ul li ul li {
                    display: list-item;
                    float: none;
                }
                #top_right ul li ul li a {
                    padding: 0 30px;
                    width: 130px;
                    height: 30px;
                    font-size: 15px;
                    line-height: 30px;
                    text-align: right;
                    background: none;
                    color: black;
                    border-bottom: 1px solid #222;
                    border-top: 1px solid #444;
                }
        .font {
          
            color:#eb8a8a;
            margin-left:60px;
        }
         .font a {
             font-size: 20px;
         }
     .cen {
         margin:0px auto;
         border:2px solid;
         border-radius:5px;
         background-color:white;
         width:900px;
         margin-top:50px;
         border-top:2px solid  rgba(200,200,200,0.25);   
          border-right:2px solid  rgba(200,200,200,0.5);   
           border-bottom: 2px solid  rgba(200,200,200,0.75);  
             border-left:2px solid  rgba(200,200,200,1);
     }



.btu {
   border-radius:3px;
    width: 165px;
    height:50px;
    background:#d9eff1;
    border-color:rgba(200,200,200,0.25);
    font-size: 15px;
    color: #4ea9ed;
    margin-left:400px;
    border:1px solid;
}

    .btu:hover {
        background:#bfdef6;
        color:#fff;
    }
     .fo {
         margin-left:30px;
     }
     .l1 {
         text-align:center;
     }
      #hr {
        width:750px;
        text-align:center;
        margin-top:0px;
        margin-left:0px;
        }
        .clear {
        clear:both;
    }
         #div_gv {
    margin-top:-180px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <link href="/css/bootstrap.min.css" rel="stylesheet" media="screen" />
	<link href="/css/font-awesome.min.css" rel="stylesheet" media="screen" />
	<link href="/css/simple-line-icons.css" rel="stylesheet" media="screen" />
        	<link href="/css/animate.css" rel="stylesheet" />
    
	<!-- Custom styles CSS -->
	<link href="/css/style.css" rel="stylesheet" media="screen" />
    <div>
    <header class="header">

		<nav class="navbar navbar-custom" role="navigation">

			<div class="container">

				<div class="navbar-header">
					<button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#custom-collapse">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
                    <img src="/images/1.jpg" id="logo" class="navbar-brand"/>
					<a class="navbar-brand" href="index.aspx">百词斩</a>
				</div>
                <div id="top_right">
                 <ul>
                <li id="li1"><a href="#">课程选择</a></li>
                <li id="li2"><a href="#">单词列表</a></li>
                <li id="li3"><a href="#"></a>
                    <asp:Label runat="server" ID="Lab_name"></asp:Label>
                           <ul>
                        <li><a>个人中心</a></li>
                        <li><a>设置</a></li>
                        <li><a href="Login.aspx">退出</a></li>
                    </ul>
                </li>
            </ul>
                    </div>
			</div>
			</nav>

	</header>
        <div style="background: #f5f5f5; position:absolute; left:0; top:0px; width:100%; height:100%; padding-top:70px;">
               <div class="cen" style="position:relative;">
                 
                   <asp:Label ID="Label1" runat="server" Text="单词列表" Font-Size="40px" ForeColor="#c0c0c0"  CssClass="fo"></asp:Label>
               
                        <asp:Button ID="Button1" runat="server" CssClass="btu" Text="开始自检单词" Width="174px" OnClick="Button1_Click1"/>
                <table style="width:960px; margin-left:50px; margin-top:20px;">
                    <tr style="width:960px;height:50px;" >
                        <td class="l1" >
                            <asp:Button ID="btn_login" runat="server" Text="已背单词"  Width="100px" Height="40px" BackColor="#4f99e3" ForeColor="#ffffff" BorderStyle="None" OnClick="btn_login_Click"/>
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="已斩单词" Width="100px" Height="40px" BackColor="#4f99e3" ForeColor="#ffffff" BorderStyle="None"/>
                        </td>
                    </tr>
                    <tr style="height:10px;">
                        <td colspan="2"><hr id="hr" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                           
                                <asp:GridView ID="gw_word" runat="server" Width="750px" AutoGenerateColumns="False" CellPadding="4"
                                     ForeColor="#333333" GridLines="None">
                                    <AlternatingRowStyle BackColor="White" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                     <Columns>
                                        <asp:BoundField DataField="cd_name" HeaderText="单词" />
                                        <asp:BoundField DataField="cd_mean" HeaderText="意思" />
                                    </Columns>
                                </asp:GridView>

                        </td>
                         </tr>
                    </table>
			
               </div> 
        </div>
     </div>
    </form>
</body>
</html>
