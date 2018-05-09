<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowTureWord.aspx.cs" Inherits="百词斩.Review_Words.ShowTureWord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-image:url(images/bg-1366x768.jpg)">
    <form id="form1" runat="server">
    <center>
       <div style="width:1200px;">
        <!--头部-->
           <div style="float:right;color:gray;margin-top:20px;">
               <span>今日目标还剩
                   <asp:Label ID="Study_Words_EveryDay" runat="server" /> 个
               </span>
               <span>今日需复习
                   <asp:Label ID="Has_Learn_Number" runat="server" Text="0"/>个
               </span>
           </div>
           <br />
           <!--单词信息-->           
           <div style="margin-top:70px;">
                   <div style="color:cornflowerblue;font-size:32px;float:left;">
                      <span style="font-size:32px">
                          <asp:Label ID="Learning_Words" runat="server" Text="Null"/>
                      </span>
                      <span>
                          <asp:ImageButton ID="SoundPlayer" ImageUrl="~/images/playing.png" Width="48px" Height="38px" runat="server" OnClick="SoundPlayer_Click" />
                      </span>
                   </div>
                   <br />
                   <span style="float:right;">
                       <asp:Button ID="btn_Cut_Word" runat="server" Text="斩" Width="70px" Height="38px" />
                    </span>
           </div>
           <br />
           <br />
           <!--单词详细信息-->
           <div style="height:500px;">
                   <div>
                       <p style="font-size:26px;color:gray;margin-right:520px;">
                       <b>例句:</b>
                       </p>
                       <span>
                           <asp:Label runat="server" ID="Learning_Words_Sentence" ></asp:Label>
                       </span>
                       <hr />
                   </div> 
               </div>
               <div style="float:right;margin-top:55px;margin-left:80px;">
                   <asp:Image runat="server" ID="True_Pic"  Width="260px" Height="200px" />
               </div>
               <br />
           </div>
           <br />
           <!--继续-->
           <div style="margin-top:20px;float:left;">
                   <div style="float:left;">
                        <asp:Button runat="server" Text="继续做题" ID="Words_Prompt" Width="300px" Height="33px"  OnClick="Words_Prompt_Click" />
                   </div>
           </div>
           <br />
           <!--操作提示-->
           <div style="margin-top:70px;float:left;margin-left:-300px;">
               <div style="float:left;color:dimgray;">
                    <asp:Label ID="Show_Operation" runat="server">操作提示   鼠标点击选择对应顺序的答案：1 2 3 4 播放单词声音 7 播放句子声音 8 斩 0</asp:Label>
               </div>
           </div>
    </div>
    </center>
    </form>
</body>
</html>
