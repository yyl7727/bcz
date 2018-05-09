<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="beikao.aspx.cs" Inherits="百词斩.Plan.beikao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function getAbsolutePosition(element) {
            var point = { x: element.offsetLeft, y: element.offsetTop };
            if (element.offsetParent) {
                var parentPoint = this.getAbsolutePosition(element.offsetParent);
                point.x += parentPoint.x;
                point.y += parentPoint.y;
            }
            return point;
        };
        function myclick() {
            var myTextbox = document.getElementById("myRegisterTime");
            var point1 = getAbsolutePosition(myTextbox);
            document.getElementById("caDiv").style.display = "block";
            document.getElementById("caDiv").style.left = point1.x;
            document.getElementById("caDiv").style.top = point1.y;
        }
        function divonclick() {
            document.getElementById("caDiv").style.display = "none";
        }
    </script>

    <style type="text/css">

        #header_right{
            width: 34%;
            float:right;
            text-align: left;
            /*margin:5px 250px 0px 0px;*/
            margin-right:-100px;
        }
        div.header_bdc div.header_right {
            float: right;
        }
            div.header_bdc div.header_right div.select-book-date-wrapper {
                width: 220px;
            }
        div.header_right h2 {
            color: #999;
            font-size: 30px;
            margin-bottom: 15px;
            display: inline-block;
        }

        #dataList:hover {
                 background:url(/images/bg-select-book-small-cover.png) no-repeat;
            }
        #dataList:active {
            background: url(/images/bg-select-book-hover-small-cover.png) no-repeat;
            }
         #dataList{
             width:110px;
             border:1px;
             height:110px;
             margin-top:15px;
             border-radius:10px;
             background:url(/images/bg-select-book-small-cover.png) no-repeat;
         }

         #beikao.selected{
             color:#4FC0DB;
         }
    </style>
</head>
<body  style="background: #f5f5f5; width:1000px;">
    <form id="form1" runat="server">
    <div class="right_1">
    <asp:DataList ID="dl_Customer" runat="server" RepeatDirection="Horizontal"  
        RepeatColumns="5" Width="600px" DataKeyField="C_ID" SelectedItemStyle-BackColor="Blue" 
        OnItemCommand="dl_Customer_ItemCommand"> 
        <ItemTemplate>
            <div id="dataList">
                <a>
                    <div>
                        <div style="width:100px;text-align:center;">
                             <div style="color: #fff;font-size: 14px;text-align: center;padding: 10px 10px;"><%# Eval("C_NAME") %></div>
                                  <div style="color: #417582;font-size: 16px;text-align: center;"><%# Eval("c_vocabulary") %>个单词</div>
                            <asp:LinkButton ID="lbtn_name" runat="server" Text="点击学习" ForeColor="White" CommandName="Select"></asp:LinkButton>
                        </div>
                    </div>
                </a>
            </div>

        </ItemTemplate>
       <SelectedItemTemplate>
           <div id="dataList">
               <a href="#?c_id=<%# Eval("C_ID") %>"> </a>
                   <a>
                       <div>
                           <div style="width:100px;text-align:center;">
                                  <div style="color: #fff;font-size: 14px;text-align: center;padding: 10px 10px;"><%# Eval("C_NAME") %></div>
                                <div style="color: #417582;font-size: 16px;text-align: center;"><%# Eval("c_vocabulary") %>个单词</div>

                           </div>
                       </div>
                   </a>
              

           </div>

       </SelectedItemTemplate>
    </asp:DataList>
    </div>
        <div id="header_right">
            <div id="select-book-date-wrapper">
                   <h1 style="color:darkgray;">选择完成日期</h1>
                <br />
                <asp:Label ID="Label1" runat="server" Text="完成日期:"></asp:Label>
                <asp:TextBox ID="myRegisterTime" runat="server" Width="114"></asp:TextBox>
                <div id="caDiv" style="display:none;position: absolute;" onclick="divonclick()">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC"
                         Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px"
                         BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" OnSelectionChanged="Calendar1_SelectionChanged"
                         >

                    </asp:Calendar>

                </div>
                <br />
                <br />
                平均每天学：<asp:Label ID="lab_words" runat="server" Font-Size="15px"></asp:Label>
                <br />
                <br />
                <asp:ImageButton ID="img_but" runat="server" Text="完成"  ImageUrl="/images/set_btn.png" OnClick="img_but_Click" />
            </div>
        </div>
    </form>
</body>
</html>
