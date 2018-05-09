<%@ Page Language="C#" AutoEventWireup="true" CodeFile="View-source.aspx.cs" Inherits="View_source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>百词斩TV 看视频学单词</title>
  <meta name="keywords" content="百词斩 背单词 英语 教育 视频 单词视频 扇贝 新东方 猿题库"/>

  <script>
      var _hmt = _hmt || [];
      (function () {
          var hm = document.createElement("script");
          hm.src = "//hm.baidu.com/hm.js?62db40018c46273c694419ccd1fc3c2d";
          var s = document.getElementsByTagName("script")[0];
          s.parentNode.insertBefore(hm, s);
      })();
  </script>

  <link rel="shortcut icon" type="image/x-icon" href="/Images/icon.ico" />
  <link href="css/application.css" media="all" rel="stylesheet" type="text/css" />
  <link href="css/base.css" rel="stylesheet" />
  <link href="css/icon.css" rel="stylesheet" />
  <link href="css/video_play.css" rel="stylesheet" />
  <link href="css/bczExpress.css" rel="stylesheet"/>
   <link href="/css/bootstrap.min.css" rel="stylesheet" media="screen" />
<link href="/css/font-awesome.min.css" rel="stylesheet" media="screen" />
	<link href="/css/simple-line-icons.css" rel="stylesheet" media="screen" />
	<link href="/css/animate.css" rel="stylesheet" />
    
	<!-- Custom styles CSS -->
	<link href="/css/style.css" rel="stylesheet" media="screen">
    
    <script src="/script/modernizr.custom.js"></script>
  <script type="text/javascript" src="scripts/polyvplayer_v2.0.min.js"></script>
  <script src="scripts/jquery.min.js"></script>
  <!–[if lt IE 9]>
  <!--<script src=”http://ie7-js.googlecode.com/svn/version/2.1(beta4)/IE9.js”></script>-->
  <![endif]–>

  <!--弹幕-->
  <link href="css/TMCSS.css" rel="stylesheet" />
  <!--<script src="/danmu/TMJS.js" rel="stylesheet" />-->

  <link href="css/globel_color.css" rel="stylesheet" />

  <script src="scripts/application.js" type="text/javascript"></script>

  <meta content="authenticity_token" name="csrf-param" />
<meta content="F8NQP8xtG99zC8kYKFOFJBzYor/H6pumAvQnt07k+gk=" name="csrf-token" />

    <style type="text/css">
    header {
        width: 100%;
    }
    .header {
        width: 1160px;
        height: 80px;
        margin: 0px auto;
    }
    .header div {
        height: 32px;
        display: inline-block;
        margin: 24px auto;
        vertical-align: top;
    }
    .header_sub_1 {
        width: 212px;
        height: 32px;
    }
    .header_sub_wb {
        width: 45px;
        line-height: 35px;
        margin-left: 30px !important;
        text-align: left;
        background-repeat: no-repeat;
        background-position: right;
    }
    .header_sub_2 {
        width: 428px;
        margin-left: 77px !important;
        margin-right: 0px !important;
        border-radius: 5px;
    }
    .header_sub_2 .query_input, .header_sub_2 .query_btn {
        height: 32px;
        float: left;
        vertical-align: top;
        line-height: 32px;
    }
    .header_sub_2 .query_input {
        width: 370px;
        border-radius: 5px;
    }
    .header_sub_2 .query_btn {
        width: 57px;
        border-top-right-radius: 5px;
        border-bottom-right-radius: 5px;
        text-align: center;
        line-height:43px;
        cursor: pointer;
    }
    .query_btn>img{
        width: 20px;
        height: 20px;
    }
    .header_sub_2 .query_btn:hover {
        background-color: #23B5F3;
    }
    .header_sub_2 input {
        height: 32px;
        width: 359px;
        border: none;
        vertical-align: top;
    }
    .header_sub_3 {
        width: 350px;
        text-align: right;
        line-height: 32px;
    }
    .header_sub_3  a {
        text-decoration: none;
        display: inline-block;
        text-align: center;
        min-width: 30px;
        margin-left: 25px;
        height: 32px;
        line-height: 32px;
        vertical-align: middle;
    }
    .header_sub_3  a:hover {
        color: #3bc3fd;
        margin-left: 25px;
    }
    .own_home_pic {
        border-radius: 100%;
        width: 25px;
        height: 25px;
        display: inline-block;
        vertical-align: middle;
        margin-bottom: 2px;
    }
    .own_home_pic>img{
        border-radius: 100%;
        width: 25px;
        height: 25px;
    }
    .word_book_choice_left div {
        height: 40px;
        line-height: 40px;
        text-align: right;
    }
    .word_book_choice_right div {
        margin-left: 10px;
        height: 40px;
    }
    .word_book_choice_right div label {
        display: inline-block;
        height: 40px;
        line-height: 40px;
        text-align: center;
        min-width: 40px;
        padding: 0px 5px;
    }

</style>
</head>
<body>
    <form id="form1" runat="server">
    <!-- 页首 -->
<header class="bg_color_fff">
  <div class="header">
    <a href="/"><div class="header_sub_1 bg_img_logo"><img src="images/logo_1.png" class="header_sub_1"/></div></a>
    <div class="header_sub_wb color_999 font_s14"></div>
    <div class="header_sub_3 font_s14" style="float:right">
              <a href="logins.aspx" class="color_999" style="min-width: 10px;">登录</a>
              <a class="color_999" style="min-width: 10px; margin-left: 0px;">/</a>
              <a href="registre.aspx" style="min-width: 10px; margin-left: 0px;" class="color_999">注册</a>
      <a href="index.aspx" class="color_999">百词斩官网</a>
    </div>
  </div>
</header>

<script type="text/javascript">
    //页首js

    $(function () {
        //搜索框点击
        $("#search_btn").on("click", function () {
            $("#search_form").submit();
        });
    });
</script>


<style>
    /*分类选择部分*/
    .content {
        width: 1160px;
        margin: 0px auto;
        padding-top: 50px;
        padding-bottom: 50px;
    }
    .content_category {
        margin: 0px auto;
    }
    .content_category div {
        display: inline-block;
        vertical-align: top;
    }
    .content_category_scroll {
        width: 465px;
        height: 310px;
        border-radius: 5px;
        overflow: hidden;
    }
    .content_categoty_scroll_pics {
        height: 260px;
        width: 465px;
        width: 100%;
        position: relative;
        overflow: hidden;
    }
    .content_categoty_scroll_nav {
        display: block !important;
        height: 50px;
        line-height: 50px;
        padding-left: 14px;
        padding-right: 14px;
    }
    .content_category_choice {
        width: 665px;
        height: 290px;
        margin-left: 25px;
    }
    .content_category_choice h3{
        margin-left: 22px;
        margin-bottom: 22px;
        vertical-align: top;
    }
    .content_category_choice .content_category_choice_block {
        width: 140px;
        height: 75px;
        margin-left: 22px;
        display: inline-block;
        vertical-align: top;
        margin-bottom: 20px;
        border-radius: 5px;
        overflow: hidden;
        cursor: pointer;
        position: relative;
    }
    .content_category_choice .content_category_choice_block>img{
        position: absolute;
        top:0px;
        left: 0px;
        width: 145px;
        height: 77px;
    }
    .content_category_choice .content_category_choice_block .content_category_choice_topblock {
        height: 45px;
        width: 100%;
        position: absolute;
        top: -45px;
    }
    .content_category_choice_topblock>img{
        width: 145px;
        height: 45px;
        position: absolute;
        left: 0px;
        top: 0px;
    }
    .content_category_choice .content_category_choice_block .content_category_choice_bottomblock {
        height: 30px;
        width: 100%;
        position: absolute;
        bottom: -30px;
    }
    .content_category_choice .content_category_choice_block .content_category_choice_bottomblock>img{
        width: 145px;
        height: 32px;
        position: absolute;
        left: 0px;
        top: 0px;
    }
    /*推荐部分*/
    .content_advice {
        margin-top: 30px;
    }
    .content_advice div {
        display: inline-block;
        vertical-align: top;
    }
    .content_advice_latest {
        width: 840px;
    }
    .content_advice_latest_toppic {
        height: 174px;
        width: 255px;
        border-top-right-radius: 5px;
        border-top-left-radius: 5px;
        cursor: pointer;
    }
    .content_advice_latest_toppic>img{
        width: 255px;
        height: 174px;
        border-top-right-radius: 5px;
        border-top-left-radius: 5px;

        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
    }
    .content_advice_latest_bottomtext h4 {
        line-height: 30px;
        padding-left: 14px;
        padding-top: 5px;
        padding-right: 14px;
    }
    .content_advice_latest_bottomtext p {
        line-height: 20px;
        padding-left: 14px;
        padding-right: 14px;
    }
    .content_advice_latest_bottomtext {
        height: 83px;
        width: 100%;
        border-radius: 5px;
        position: relative;
        overflow: hidden;
    }
    .content_advice_latest_bottomtext_difficult {
        width: 100%;
        text-align: right;
        height: 30px;
        position: absolute;
        bottom: 0px;
        border-radius: 5px;
    }
    .content_advice_latest_bottomtext_difficult label {
        display: inline-block;
        height: 20px;
        min-width: 35px;
        line-height: 20px;
        text-align: center;
        margin-right: 14px;
        margin-top: 5px;
    }
    .content_advice_latest_bottomtext_difficult img {
        vertical-align: middle;
    }
    .content_advice_latest_bottomtext_difficult span {
        vertical-align: middle;
    }
    .content_advice_heat {
        width: 310px;
    }
    .content_advice_head {
        height: 60px;
        width: 100%;
        line-height: 60px;
    }
    .content_advice_head a {
        float: right;
        margin-right: 25px;
        text-decoration: none;
    }
    .content_advice_latest_choice {
        width: 100%;
    }
    .content_advice_latest_choice .content_advice_latest_choice_block {
        width: 255px;
        height: 250px;
        margin-right: 20px;
        margin-bottom: 20px;
        border-radius: 5px;
        margin-bottom: 28px;
        cursor: pointer;
        border-top-left-radius: 5px;
        border-top-right-radius: 5px;
    }
    .content_advice_heat_choice ul {
        width: 310px;
    }
    .content_advice_heat_choice ul li {
        display: block;
        word-break: break-all;
        margin-bottom: 45px;
        line-height: 20px;
    }
    .content_advice_heat_choice ul li label {
        width: 290px;
        vertical-align: top;
        cursor: pointer;
    }
    .circle_span {
        border-radius: 100%;
        display: inline-block;
        width: 6px;
        height: 6px;
        margin-right: 10px;
        vertical-align: top;
        margin-top: 7px;
    }
    .circle_span_h3 {
        border-radius: 100%;
        display: inline-block;
        width: 6px;
        height: 6px;
        margin-left: 5px;
        margin-top: -3px;
        vertical-align: middle;
    }

</style>

<div class="bg_color_f0f0f0">
<!-- 主体 -->
<div class="content bg_color_f0f0f0">

  <!-- ********** 分类选择部分 ************ -->
  <div class="content_category">
    <!-- 视频 -->
    <div class="content_category_scroll bg_color_fff">
      <div class="content_categoty_scroll_pics bg_color_999">
           <video controls="controls " width="465" height="260px">
                        <source src="Video/TV_frist~1.mp4" type="audio/mp4" />
                   </video> 
        <%--<div class="player">
          <!-- ************** 视频插件 ***************** -->

          <script type="text/javascript" src="js/polyvplayer_v2.0.min.js"></script>
          <div id="player">            
          </div>
          <!-- ************** 视频插件结束 ***************** -->
        </div>--%>
      </div>
      <div class="content_categoty_scroll_nav font_s14 color_999">
        单词TV使用指南
      </div>
    </div>
    <!-- 选择 -->
    <div class="content_category_choice">
      <h3 class="font_s20 color_666">请选择你的单词书
        <span class="circle_span_h3 bg_color_666"></span>
        <span class="circle_span_h3 bg_color_666"></span>
        <span class="circle_span_h3 bg_color_666"></span>
      </h3>
                  <a href="/book/1">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/9_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-2.png"/></div>
                  </div>
                  </a>
                  <a href="/book/2">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/12_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-2.png"/></div>
                  </div>
                  </a>
                  <a href="/book/3">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/2_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-2.png"/></div>
                  </div>
                  </a>
                  <a href="/book/4">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/3_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-2.png"/></div>
                  </div>
                  </a>
                  <a href="/book/9">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/7_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-3.png"/></div>
                  </div>
                  </a>
                  <a href="/book/11">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/11_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-3.png"/></div>
                  </div>
                  </a>
                  <a href="/book/12">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/10_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-3.png"/></div>
                  </div>
                  </a>
                  <a href="/book/5">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/1_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-4.png"/></div>
                  </div>
                  </a>
                  <a href="/book/6">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/8_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-4.png"/></div>
                  </div>
                  </a>
                  <a href="/book/7">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/6_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-5.png"/></div>
                  </div>
                  </a>
                  <a href="/book/8">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/5_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-5.png"/></div>
                  </div>
                  </a>
                  <a href="/book/10">
                  <div class="bg_color_3bc3fd content_category_choice_block">
                    <img src="images/4_book_face.png" style="margin-left: -3px;"/>
                    <div class="content_category_choice_topblock font_s20 color_fff bg_img_begin"><img src="images/begin.png"/></div>
                    <div class="content_category_choice_bottomblock"><img src="images/copy-5.png"/></div>
                  </div>
                  </a>
    </div>
  </div>

  <!-- *********************************** -->

  <!-- ************ 推荐部分 ************** -->
  <div class="content_advice">
    <!-- 左侧最新推荐 -->
    <div class="content_advice_latest">
      <div class="content_advice_head">
        <a href="splaylists?order=created_at" class="color_3bc3fd font_s14">更多 >></a>
        <h3 class="color_666 font_s20">最新推荐
          <span class="circle_span_h3 bg_color_666"></span>
          <span class="circle_span_h3 bg_color_666"></span>
          <span class="circle_span_h3 bg_color_666"></span>
        </h3>
      </div>
      <div class="content_advice_latest_choice">

            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000319">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150811181323_重口小讲堂.png"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">重口小讲堂</h4>
                  <p class="color_999 font_s12">传播重口画面是我们的职责！
</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-5.png" /></label>
                </div>
              </div>
              </a>
            </div>
            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000762">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150916170445_看mv学单词.jpg"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">看MV学单词VOL.1</h4>
                  <p class="color_999 font_s12">跟着MV来刷词！</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-3.png" /></label>
                </div>
              </div>
              </a>
            </div>
            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000018">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150907105543_toefl-cover.png"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">托福单词课</h4>
                  <p class="color_999 font_s12">斩家老师帮你全面掌握托福考点


</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-5.png" /></label>
                </div>
              </div>
              </a>
            </div>
            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000513">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150912151023_embarrassed knowledge－0818.png"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">羞羞的知识</h4>
                  <p class="color_999 font_s12">未满18请撤离
</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-5.png" /></label>
                </div>
              </div>
              </a>
            </div>
            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000764">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150926142733_cover－易混词.jpg"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">易混词合辑VOL.1</h4>
                  <p class="color_999 font_s12">一次讲清易混点！
</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-1.png" /></label>
                </div>
              </div>
              </a>
            </div>
            <div class="bg_color_fff content_advice_latest_choice_block">
              <a href="/playlist/1000509">
                    <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150812105351_mangahero2.png"/></div>

              <div class="content_advice_latest_bottomtext bg_color_fff">
                <div style="display: block;">
                  <h4 class="font_s14 color_666">上吧!!英雄联盟!</h4>
                  <p class="color_999 font_s12">看看英雄都有哪些技能</p>
                </div>
                <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                    <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-1.png" /></label>
                </div>
              </div>
              </a>
            </div>

      </div>
    </div>
    <!-- 右侧推荐 -->
    <div class="content_advice_heat">
      <div class="content_advice_head">
        <a href="#" class="color_3bc3fd font_s14"  style="margin-right: 5px;"></a>
        <h3 class="color_666 font_s20"></h3>
      </div>
      <div class="content_advice_heat_choice color_666 font_s14">
        <ul>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=bawdy"><label>&quot;黄段子&quot;怎么说？</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=drive"><label>挖掘机也能玩儿漂移！</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=underestimate"><label>Adele回归！来回味下曾经的经典！</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=stigma"><label>“黑历史”最早来源于哪儿？</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=wrap"><label>如果超人来自印度……</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=recycle"><label>贝爷如何在沙漠中Recycle水资源？</label></a>
                  </li>

                  <li><span class="circle_span bg_color_3bc3fd"></span>
                        <a class="color_666" href="/search?keyword=restless"><label>紧张的时候怎么办？（未成年不要学）</label></a>
                  </li>
        </ul>
      </div>
    </div>

    <!-- 左侧最热推荐 -->
    <div class="content_advice">
      <div class="content_advice_latest">
        <div class="content_advice_head">
          <a href="/splaylists?order=play_count" class="color_3bc3fd font_s14">更多 >></a>
          <h3 class="color_666 font_s20">热门推荐
            <span class="circle_span_h3 bg_color_666"></span>
            <span class="circle_span_h3 bg_color_666"></span>
            <span class="circle_span_h3 bg_color_666"></span>
          </h3>
        </div>
        <div class="content_advice_latest_choice">

              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000760">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150829181744_cover－virgo.png"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">谜之处女座</h4>
                    <p class="color_999 font_s12">还原一个真实的处女座~
</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-2.png" /></label>

                  </div>
                </div>
                </a>
              </div>
              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000761">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150829181607_开学季.png"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">开学啦！</h4>
                    <p class="color_999 font_s12">那些课堂上发生的趣事~
</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-2.png" /></label>

                  </div>
                </div>
                </a>
              </div>
              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000762">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150916170445_看mv学单词.jpg"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">看MV学单词VOL.1</h4>
                    <p class="color_999 font_s12">跟着MV来刷词！</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-3.png" /></label>

                  </div>
                </div>
                </a>
              </div>
              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000763">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150925160849_cover－一起过中秋.png"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">一起过中秋</h4>
                    <p class="color_999 font_s12">那些和中秋有关的单词～
</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-2.png" /></label>

                  </div>
                </div>
                </a>
              </div>
              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000764">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150926142733_cover－易混词.jpg"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">易混词合辑VOL.1</h4>
                    <p class="color_999 font_s12">一次讲清易混点！
</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-1.png" /></label>

                  </div>
                </div>
                </a>
              </div>
              <div class="bg_color_fff content_advice_latest_choice_block">
                <a href="/playlist/1000509">
                      <div class="content_advice_latest_toppic bg_color_999"><img src="images/bcztv_20150812105351_mangahero2.png"/></div>

                <div class="content_advice_latest_bottomtext bg_color_fff">
                  <div style="display: block;">
                    <h4 class="font_s14 color_666">上吧!!英雄联盟!</h4>
                    <p class="color_999 font_s12">看看英雄都有哪些技能</p>
                  </div>
                  <div class="content_advice_latest_bottomtext_difficult bg_color_fff">
                        <label class="font_s12 color_3bc3fd"><span>学霸指数：</span><img src="images/start-1.png" /></label>

                  </div>
                </div>
                </a>
              </div>

        </div>

      </div>
      <!-- **************** 右侧faq ********************** -->
      <div id="wenda" class="content_advice_heat"></div>
    </div>
  </div>
</div>

</div>

<!-- 临时节点 存储视频ID -->
<div style="display: none" id="videos_room"></div>

<style>
    .footer {
        height: 150px;
        width: 800px;
        margin: 0px auto;
    }
    .footer p label * {
        vertical-align: middle;
    }
    .footer p {
        display: block;
        height: 100px;
        line-height: 100px;
        text-align: center;
    }
    .footer p label {
        margin: 0px 40px;
    }
    .footer p label span {
        margin: 0px 5px;
    }
    .footer .public  {
        text-align: center;
    }
    .footer .public a, .footer p label {
        opacity: 0.4;
    }
    .footer p label:hover, .footer .public a:hover {
        opacity: 0.8;
    }
</style>


<footer id="footer">
		<div class="container">
			<div class="row">

				<div class="col-sm-12">

					<ul class="social-links">
						<li><a href="index.aspx" class="wow fadeInUp"><i class="fa fa-facebook"></i></a></li>
						<li><a href="index.aspx" class="wow fadeInUp" data-wow-delay=".1s"><i class="fa fa-twitter"></i></a></li>
						<li><a href="index.aspx" class="wow fadeInUp" data-wow-delay=".2s"><i class="fa fa-google-plus"></i></a></li>
						<li><a href="index.aspx" class="wow fadeInUp" data-wow-delay=".4s"><i class="fa fa-pinterest"></i></a></li>
						<li><a href="index.aspx" class="wow fadeInUp" data-wow-delay=".5s"><i class="fa fa-envelope"></i></a></li>
					</ul>

					<p class="heart">
                        Made with <span class="fa fa-heart fa-2x animated pulse"></span> in Nottingham
                    </p>
                    <p class="copyright">
                        © 2015 John Doe | Images: <a href="https://unsplash.com/">Unsplash</a> & <a href="http://zoomwalls.com/">Zoomwalls</a>
					</p>

				</div>

			</div><!-- .row -->
		</div><!-- .container -->
	</footer>
<!-- ************************************ JS ***************************************************** -->
<script type="text/javascript">
    //首页js

    //将视频ID临时放入页面隐藏DIV中
    $('#videos_room').append("<span>f445c74f8ca07348978f7ad123372098_f#为何你记住了图而没记住单词？</span>");
    $('#videos_room').append("<span>f445c74f8c24cd80647f37dd5ecd0336_f#为什么用百词斩学单词会上瘾？</span>");
    $('#videos_room').append("<span>f445c74f8c143ddb9a33c8252513d863_f#背单词如何变得有动力？</span>");
    $('#videos_room').append("<span>f445c74f8c6b8b14e1a427ea3b091165_f#出国留学的少侠可以选什么学习材料？</span>");
    $('#videos_room').append("<span>f445c74f8c9b1cd94268d907b6ae7710_f#proud</span>");
    $('#videos_room').append("<span>f445c74f8cb88042aac6e963ba76570d_f#关于我们-百词斩</span>");
    $('#videos_room').append("<span>f445c74f8c85659cf837768f6c1ce12d_f#如何增加背单词的成就感？</span>");
    $('#videos_room').append("<span>f445c74f8c3bf5607e95b48d4cc5ea7f_f#如何学习那些杀千刀的易混词？</span>");
    $('#videos_room').append("<span>f445c74f8c3fcf3558f7bd549a04e19a_f#百词斩是如何帮助少侠记单词的？</span>");
    $('#videos_room').append("<span>f445c74f8cf5e0cac3bb5a7241dd6286_f#如何学习一词多义？</span>");
    $('#videos_room').append("<span>f445c74f8c59a125809607625233fd88_f#为什么考四六级总是下不了决心好好学？</span>");
    $('#videos_room').append("<span>f445c74f8c264f778ee8b4074d846414_f#如何更好地坚持完成学习计划？</span>");
    $('#videos_room').append("<span>f445c74f8c966348526c758afcd87238_f#百词斩为什么要用图片来背单词？</span>");
    $('#videos_room').append("<span>f445c74f8c27655dab82ff7e7277017a_f#百词斩掌柜是怎样学好英语的？</span>");
    $('#videos_room').append("<span>f445c74f8c976dea4e031b8fd1f29fad_f#为什么斩家不用真题做例句？</span>");
    $('#videos_room').append("<span>f445c74f8ca4d017ffb5da92d8ec2eff_f#怎样安排听说读写的学习顺序？</span>");
    $('#videos_room').append("<span>f445c74f8ccaa6a8b35947d003d2f857_f#百词斩招聘啦！</span>");
    $('#videos_room').append("<span>f445c74f8c264f778ee8b4074d846414_f#如何更好地坚持完成学习计划？</span>");
    $('#videos_room').append("<span>f445c74f8c3d6e425db81e561e53c77e_f#百词斩会收费吗？</span>");
    $('#videos_room').append("<span>f445c74f8c2c4a7aad99bc8a4f2e9ca4_f#为什么要背单词？</span>");
    $('#videos_room').append("<span>f445c74f8cfed0947bf1c8152a2e4d24_f#百词斩会关门大吉吗？</span>");
    $('#videos_room').append("<span>=f445c74f8c386944b57398d63f2a0bde_f#为什么要背那么多单词？</span>");

    //将视频ID查询并插入到JS数组
    var videos = [];
    $('#videos_room span').each(function (o) {
        videos.push($(this).text());
    });
    //删除临时视频ID节点
    $('#videos_room').remove();
    //页面加载事件
    $(function () {
        //页面加载后直接播放
        playVideo();
        //分类选择框滑动效果
        $('.content_category_choice_block').hover(function () {
            $(this).find(".content_category_choice_topblock").animate({ "top": "0px" }, 100);
            $(this).find(".content_category_choice_bottomblock").stop().animate({ "bottom": "0px" }, 100);
        }, function () {
            $(this).find(".content_category_choice_topblock").animate({ "top": "-45px" }, 100);
            $(this).find(".content_category_choice_bottomblock").stop().animate({ "bottom": "-30px" }, 100);
        });
        //推荐内容鼠标经过效果
        $('.content_advice_latest_choice_block').hover(function () {
            //鼠标移入 隐藏难度
            $(this).find('.content_advice_latest_bottomtext_difficult').stop().animate({ "bottom": "-30px" }, 100);
        }, function () {
            //鼠标移出 显示难度
            $(this).find('.content_advice_latest_bottomtext_difficult').stop().animate({ "bottom": "0px" }, 100);
        });
        //问答
        $('#wenda').load("/qaRecomends_index");
    });

    //    //视频播放函数
    //    var video_index = 0;
    //    function playVideo() {
    //        //切换视频VID 播放下一视频
    //        if(video_index >= videos.length) {
    //            video_index = 0;
    //        }
    //        $('.content_categoty_scroll_nav').text(videos[video_index].split('#')[1]);
    //        $("#player").html("");
    //        polyvObject('#player').videoPlayer({
    //            'width':'427',
    //            'height':'242',
    //            'vid' : videos[video_index].split('#')[0],
    //            'flashvars':{"autoplay":"true", "barHideTime":1,"barrage_rollTime":15}
    //        });
    //        video_index++;
    //    }
    //
    //    //视频播放结束回调函数
    //    function s2j_onPlayOver() {
    //        playVideo();
    //    }

    // 轮播改为播放单个视频
    var video_index = 0;
    function playVideo() {
        //切换视频VID 播放下一视频
        if (video_index >= videos.length) {
            video_index = 0;
        }
        $('.content_categoty_scroll_nav').text(videos[video_index].split('#')[1]);
        $("#player").html("");
        polyvObject('#player').videoPlayer({
            'width': '467',
            'height': '262',
            'vid': videos[video_index].split('#')[0],
            'flashvars': { "autoplay": "true", "barHideTime": 1, "barrage_rollTime": 15 }
        });
    }

</script>
        <script src="/scripts/jquery-1.11.1.min.js"></script>
	<script src="/scripts/bootstrap.min.js"></script>
	<<script src="/scripts/jquery.parallax-1.1.3.js"></script>
	<script src="/scripts/imagesloaded.pkgd.js"></script>
	<script src="/scripts/jquery.sticky.js"></script>
	<script src="/scripts/smoothscroll.js"></script>
	<script src="/scripts/wow.min.js"></script>
    <script src="/scripts/jquery.easypiechart.js"></script>
    <script src="/scripts/waypoints.min.js"></script>
    <script src="/scripts/jquery.cbpQTRotator.js"></script>
	<script src="/scripts/custom.js"></script>
    </form>
</body>
</html>
