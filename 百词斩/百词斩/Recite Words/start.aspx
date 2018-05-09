<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="百词斩.Recite_Words.start" %>

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
                font-size:20px;
            }

  </style>

 
</head>

<body style="background: #f5f5f5;">
    <form id="form1" runat="server">
     <link href="/css/bootstrap.min.css" rel="stylesheet" media="screen" />
	<link href="/css/font-awesome.min.css" rel="stylesheet" media="screen" />
	<link href="/css/simple-line-icons.css" rel="stylesheet" media="screen" />
     <link href="/css/animate.css" rel="stylesheet" />
    
	<!-- Custom styles CSS -->
	<link href="/css/style.css" rel="stylesheet" media="screen" />
    <link href="css/Style.css" rel="stylesheet" media="screen" />
        <link href="js/statr.js" rel="stylesheet" media="screen" />
    <div >
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
                <li id="li3"><a href="#">
                    <asp:Label ID="Lab_name" runat="server"></asp:Label>
                    </a>
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
        	</div>
 <div class="index_main">

  <div class="user-index-wrapper">
	<div class="index_main clearfix">
		<div class="index_leftside">
	    	<div class="index_left_topbar">
	             <div class="index_left_title">距离完成<span><asp:Label ID="lab_view" runat="server" Text="Label" Font-Size="30px"></asp:Label></span></div>
	            <div class="index_left_title">还剩 <b>
                    <asp:Label ID="lab_view_days" runat="server" Text="Label" Font-Size="30px"></asp:Label></b> 天<a href="../Plan/Select.aspx">更改计划</a></div>
	            <div class="index_left_title index_small_title"><p>完成 <b>
                    <asp:Label ID="lab_view_finish" runat="server" Text="Label"></asp:Label></b> / <asp:Label ID="lab_view_number" runat="server" Text="Label"></asp:Label></p><a href="../List/list.aspx">查看</a></div>
	            <div class="index_progress"><p style="width:4.56140350877193%">&nbsp;</p></div>
	        </div>
	
            <div class="index_left_bottombar">
	        	<div class="index_left_ii clearfix">
	              <div style="margin-left:70px;">今日新学<p>
                      <asp:Label ID="lab_xinxue" runat="server" Text="Label"></asp:Label></p></div>
	              <div>今日目标
			      
			         <p>
                         <asp:Label ID="lab_view_words" runat="server" Text="Label"></asp:Label></p>
                    
                      <p>
                      </p>
				  </div>
	            </div>

				<!-- new -->
					<div class="user-msg-block">					
			    </div>

			  
			 
			        <div class="index_bei_btn">
                  
                        <asp:Button ID="Button1" runat="server" CssClass="btn" Text="开始背单词吧" OnClick="Button1_Click"/>
                        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click"/>
				<!-- end of new -->
	        </div>

	</div>
        </div>
            </div>
     </div>
</div>
    </form>
</body>
</html>
