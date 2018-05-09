<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="description" content="">
	<meta name="author" content="">

	<title>百词斩</title>

	<!-- CSS -->
	<link href="/css/bootstrap.min.css" rel="stylesheet" media="screen" />
	<link href="/css/font-awesome.min.css" rel="stylesheet" media="screen" />
	<link href="/css/simple-line-icons.css" rel="stylesheet" media="screen" />
	<link href="/css/animate.css" rel="stylesheet"/>
    
	<!-- Custom styles CSS -->
	<link href="/css/style.css" rel="stylesheet" media="screen"/>
    
    <script src="/script/modernizr.custom.js"></script>
       
</head>
<body>
    <form id="Form1" runat="server">
	<!-- Home start -->

	<section id="home" class="pfblock-image screen-height">
        <div class="home-overlay"></div>
		<div class="intro">
			<div class="start">Hello, Welcome to BaiCiZhan.</div>
		</div>

        <a href="#services">
		<div class="scroll-down">
            <span>
                <i class="fa fa-angle-down fa-2x"></i>
            </span>
		</div>
        </a>

	</section>

	<!-- Home end -->

	<!-- Navigation start -->

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

				<div class="collapse navbar-collapse" id="custom-collapse">
					<ul class="nav navbar-nav navbar-right">
						<li><a href="#services">首页</a></li>
						<li><a href="logins.aspx">背单词</a></li>
                        <li><a href="View-source.aspx">单词TV</a></li>
                        <li><a href="#jiar">加入我们</a></li>
					</ul>
				</div>

			</div><!-- .container -->

		</nav>

	</header>

	<!-- Navigation end -->

    <!-- Services start -->

	<section id="services" class="pfblock pfblock-gray">
		<div class="container">

			<div class="row">

				<div class="col-sm-3">

					<div class="iconbox wow slideInLeft">
						
						<div class="iconbox-text">
							<h2 class="iconbox-title">crawl</h2>
						</div>
					</div>

				</div>

				<div class="col-sm-3">

					<div class="iconbox wow slideInLeft">
						
						<div class="iconbox-text">
							<h2 class="iconbox-title">despise</h2>
						</div>
					</div>

				</div>
                <div class="col-sm-3">

					<div class="iconbox wow slideInRight">
						
						<div class="iconbox-text">
							<h2 class="iconbox-title">spray</h2>
						</div>
					</div>

				</div>
                <div class="col-sm-3">

					<div class="iconbox wow slideInRight">
						
						<div class="iconbox-text">
							<h2 class="iconbox-title">happy</h2>
						</div>
					</div>

				</div>
			</div><!-- .row -->
            	<div class="row">

				<div class="col-sm-6 col-sm-offset-3">

					<div class="pfblock-header wow fadeInUp">
						<h2 class="pfblock-title">单词TV，把单词演出来</h2>
						<div class="pfblock-line"></div>
						<div class="pfblock-subtitle">
                            选一个不认识的单词试试，看看会发生什么？
						</div>
                        <div style="margin-top:50px;">
                        <asp:Button ID="btn" runat="server" Text="查看更多" CssClass="transButton"/>
                            </div>
					</div>

				</div>

			</div>
		</div><!-- .container -->
	</section>

	<!-- Services end -->

    


	<!-- Footer start -->

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

	<!-- Footer end -->

	<!-- Scroll to top -->

	<div class="scroll-up">
		<a href="#home"><i class="fa fa-angle-up"></i></a>
	</div>
    
    <!-- Scroll to top end-->

	<!-- Javascript files -->

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