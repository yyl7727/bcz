<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Study_Words.aspx.cs" Inherits="百词斩.Recite_Words.Study_Words" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-image:url(images/bg-1366x768.jpg)">
    <form id="form1" runat="server">
    <center>
      <div style="width:1200px;" >
       <!--头部-->
       <div style="float:right;color:gray;margin-top:20px;">
           <span>今日学习了
               <asp:Label ID="Study_Words_EveryDay" runat="server" /> 个
           </span>
           <span>今日需复习
               <asp:Label ID="Has_Learn_Number" runat="server" Text="0"/>个
           </span>
       </div>
       <br />
       <!--单词信息-->    
       <div class="wrap_top">
           <div style="margin-top:70px;">
              <div style="color:cornflowerblue;font-size:32px;float:left;">
                 <span>
                     <asp:Label ID="Learning_Words" runat="server" Text="Null"/>
                 </span>
                  <span>
                     <asp:ImageButton ID="SoundPlayer" ImageUrl="~/images/playing.png" Width="48px" Height="38px" runat="server" OnClick="SoundPlayer_Click" />
                 </span>
              </div>
              <br />
              <br />
              <br />
              <div style="color:dimgray;font-size:32px;float:left">
                 <p>
                     <asp:Label ID="Learning_Words_Sentence" runat="server" Text="Null"/> 
                 </p>
              </div>
              
              <div style="float:right;margin-right:60px;">
                 <span>
                     <asp:Button ID="btn_Cut_Word" runat="server" Text="斩" Width="60px" Height="30px" Font-Size="17px" BackColor="Lightgray" OnClick="btn_Cut_Word_Click" />
                 </span>
              </div>
           </div>
       </div>
           <!--单词图片显示-->
       <div style="margin-top:70px;height:475px;">      
               <div style="width:465px;height:400px;margin-right:800px;">
                   <div style="width:465px;height:200px;">
                        <div style="float:left;width:230px;height:200px;">
                            <span>
                                 <div style="float:left;margin-top:10px;">
                                     <span>1</span>
                                 </div>
                                 <div style="margin-top:25px;margin-left:10px;">
                                     <asp:ImageButton runat="server" ID="Pic_1" Width="200px" Height="160px" ImageUrl= '<%#"getpic1.aspx?cd_id="+Eval("cd_id")+""%>' OnClick="Pic_1_Click"/>
                                 </div>
                          </span>
                        </div>
                        <div style="float:left;width:230px;height:200px;">
                            <span style="margin-left:30px;">
                                 <div style="float:left;margin-top:10px;">
                                     <span>2</span>
                                 </div>
                                 <div style="margin-top:10px;margin-left:10px;">
                                     <asp:ImageButton runat="server" ID="Pic_2" Width="200px" Height="160px" ImageUrl= '<%#"getpic2.aspx?cd_id="+Eval("cd_id")+""%>' OnClick="Pic_2_Click" />
                                 </div>
                          </span>
                        </div>
                   </div>
                   <div style="width:465px;height:200px;">
                        <div style="float:left;width:230px;height:200px;">
                            <span style="margin-left:30px;">
                                 <div style="float:left;margin-top:10px;">
                                     <span>3</span>
                                 </div>
                                 <div style="margin-top:10px;margin-left:10px;">
                                     <asp:ImageButton runat="server" ID="Pic_3" Width="200px" Height="160px" ImageUrl= '<%#"getpic3.aspx?cd_id="+Eval("cd_id")+""%>' OnClick="Pic_3_Click" />
                                 </div>
                          </span>
                        </div>
                        <div style="float:left;width:230px;height:200px;">
                            <span style="margin-left:30px;">
                                 <div style="float:left;margin-top:10px;">
                                     <span>4</span>
                                 </div>
                                 <div style="margin-top:10px;margin-left:10px;">
                                     <asp:ImageButton runat="server" ID="Pic_4" Width="200px" Height="160px" ImageUrl= '<%#"getpic4.aspx?cd_id="+Eval("cd_id")+""%>' OnClick="Pic_4_Click" />
                                 </div>
                          </span>
                        </div>
                      </div>
               </div>
           <!--单词详细信息-->
           <div style="font-size:28px;float:right;margin-top:-350px;margin-right:500px;">
               <div>
                   <asp:Label runat="server" ID="Words" />
               </div>
               <div style="margin-top:10px;font-size:28px;">
                   <asp:Label runat="server" ID="Translate" />
               </div>
           </div>
       </div>
       <!--提示-->
        <div style="margin-top:30px;">
            <div style="float:left;">
                 <asp:Button runat="server" Text="给点儿提示" ID="Words_Prompt" Width="300px" Height="33px" OnClick="Words_Prompt_Click"/>
            </div>
        </div>
        <br />
       <!--操作提示-->
       <div style="margin-top:50px;">
           <div style="float:left;color:dimgray;">
                <asp:Label ID="Show_Operation" runat="server">操作提示   鼠标点击选择对应顺序的答案：1 2 3 4 播放单词声音 7 播放句子声音 8 斩 0</asp:Label>
           </div>
           <%--<div style="float:right;">
               <asp:ImageButton runat="server" ImageUrl="~/images/百词斩.png" Width="120px" Height="80px" PostBackUrl="Plan_Or_Task.aspx"/>
           </div>--%>
       </div>
     </div>
    </center>
    </form>
</body>
</html>
