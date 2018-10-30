<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectExam.aspx.cs" Inherits="SelectExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TichEdu</title>
	<meta charset="utf-8">
	<!--[if IE]>
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<![endif]-->
	<meta name="description" content="">
	<meta name="viewport" content="width=device-width, initial-scale=1">

	<!-- Place favicon.ico and apple-touch-icon.png in the root directory -->

	<link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/animations.css">
	<link rel="stylesheet" href="css/fonts.css">
	<link rel="stylesheet" href="css/main.css" class="color-switcher-link">
	<link rel="stylesheet" href="css/shop.css">
	<link rel="stylesheet" href="css/custom.css">
	<script src="js/vendor/modernizr-2.6.2.min.js"></script>
	
	
	

<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

	<!--[if lt IE 9]>
		<script src="js/vendor/html5shiv.min.js"></script>
		<script src="js/vendor/respond.min.js"></script>
		<script src="js/vendor/jquery-1.12.4.min.js"></script>
	<![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!--[if lt IE 9]>
		<div class="bg-danger text-center">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/" class="highlight">upgrade your browser</a> to improve your experience.</div>
	<![endif]-->
	<div class="preloader">
		<div class="preloader_image"></div>
	</div>

	<!-- search modal 
	<div class="modal" tabindex="-1" role="dialog" aria-labelledby="search_modal" id="search_modal">
		<button type="button" class="close" data-dismiss="modal" aria-label="Close">
			<span aria-hidden="true">
				<i class="rt-icon2-cross2"></i>			</span>		</button>
		<div class="widget widget_search">
			<form method="get" class="searchform search-form form-inline" action="#">
				<div class="form-group bottommargin_0">
					<input type="text" value="" name="search" class="form-control" placeholder="Search keyword" id="modal-search-input">
				</div>
				<button type="submit" class="theme_button">Search</button>
			</form>
		</div>
	</div>--->

	<!-- Unyson messages modal -->
	<div class="modal fade" tabindex="-1" role="dialog" id="messages_modal">
		<div class="fw-messages-wrap ls with_padding">
			<!-- Uncomment this UL with LI to show messages in modal popup to your user: -->
			<!--
		<ul class="list-unstyled">
			<li>Message To User</li>
		</ul>
		-->
		</div>
	</div>
	<!-- eof .modal -->

	<!-- wrappers for visual page editor and boxed version of template -->
	<div id="canvas">
		<div id="box_wrapper">

			<!-- template sections -->

			<section class="page_topline ls ms table_section table_section_sm" style="padding:20px;">
				<div class="container">
					<div class="row">
					<div class="col-sm-6 "  style="float:right;">									
						<!--<div class="form-group">
							<label for="mailchimp" class="sr-only">Search here</label>
							<i class="flaticon-envelope icon2-"></i>
							<input name="" type="search" id="mailchimp" class="mailchimp_email form-control" placeholder="Search">
							<button type="submit" class="theme_button color1"><i class="fa fa-search"></i></button>
						</div>-->
					 </div>
					  
						<div class="col-sm-6 text-center text-sm-right">
							<ul class="inline-list menu darklinks">
							<li>	<asp:LinkButton ID="Profile_link_btn" class="fa fa-user" OnClick="Profile_link_btn_Click" runat="server">Profile</asp:LinkButton>
                                    
								</li>
                                <li><a href="login-student.aspx" class="small-text medium"><i class="fa fa-sign-out"></i>Sign out</a></li>
                                
							</ul>
						</div>
					</div>
				</div>
			</section>


			<header class="page_header_side page_header_side_sticked active-slide-side-header ls">
				<span class="toggle_menu_side header-slide">
					<span></span>				</span>
				<div class="scrollbar-macosx">
					<div class="side_header_inner">
						<div class="header-side-menu darklinks">
							<!-- main side nav start -->
							<nav class="mainmenu_side_wrapper">
							<a href="index.html" class="logo top_logo">
								<img src="images/logo.png" alt="">							</a>	
								<ul class="nav menu-click">
									<li class="active">
										<li class="active">
								   
									 <asp:LinkButton ID="Pdfnoteslink_btn"  OnClick="Pdfnoteslink_btn_Click" runat="server">TichEdu Pdf Notes</asp:LinkButton>
								


									</li>
                                    <li>
											
									 <asp:LinkButton ID="video_link"  OnClick="video_link_Click" runat="server">TichEdu Tutorials</asp:LinkButton>
								
									</li>
									<!--<li>
										<a href="Youtube.aspx">YouTube</a>
									</li>-->
									
									<li>
									<asp:LinkButton ID="examlink"  OnClick="examlink_Click" runat="server">TichEdu Exam</asp:LinkButton>
									</li>
									<li>
										 <asp:LinkButton ID="Youtubevideos"  OnClick="Youtubevideos_Click" runat="server">TichEdu YouTube Videos</asp:LinkButton>
									</li>
									<li>
										 <asp:LinkButton ID="Youtubelive"  OnClick="Youtubelive_Click" runat="server">TichEdu YouTube Live</asp:LinkButton>
									</li>
                                    <li>
										 <asp:LinkButton ID="Groupchat"  OnClick="Groupchat_Click" runat="server">TichEdu Group chat</asp:LinkButton>
									</li>
								<!-- eof pages -->
								</ul>
							</nav>
							<!-- eof main side nav -->
							
<div class="container text-center">
	<div class="row">
        <div class="round hollow text-center">
         
	</div>
</div>
						</div>
					</div>
				</div>
			</header>




			<section class="ls page_portfolio section_padding_top_10 section_padding_bottom_75" style="background-image:url(images/exmbg.jpg); background-attachment:fixed; background-repeat:no-repeat; background-size: cover; height: 100vh;">
				<div class="container">
					<div class="bgwt" style="background-color:rgba(255,255,255,0.9)">
						<div class="row">
							<div class="col-sm-12 col-md-12">
	
	
	
					<div class="container">
					<h3 class="widget-title">Select Exam</h3>
					<div class="">
						<p class="text-danger">Class</p>
						 <asp:DropDownList CssClass="form-control" ID="DrpClass" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DrpClass_SelectedIndexChanged">
                </asp:DropDownList>
						<p class="text-danger">Subject</p>
						<asp:DropDownList ID="DrpSubject" CssClass="form-control" runat="server" AutoPostBack="True"  OnSelectedIndexChanged="DrpSubject_SelectedIndexChanged" >
                </asp:DropDownList>
						<p class="text-danger">Exam name</p>
						<asp:DropDownList ID="DrpExam" CssClass="form-control" runat="server" AutoPostBack="True"   
                         
                            >
                </asp:DropDownList>
						<p class="text-danger"> </p>
						
						   <asp:Button ID="submitbtn" runat="server" class="form-control" Text="Submit" OnClick="submitbtn_Click" />
						<span id="message" style="color:Red;"></span> </div>
					</div>      
			 
	
	
	
	
	
	
	
							</div>
						</div>
					</div>
				</div>
			</section>



			<section class="cs page_copyright section_padding_15 with_top_border_container">
				<div class="container">
					<div class="row">
						<div class="col-sm-12 text-center">
							<p>Designed by AimSoft</p>
						</div>
					</div>
				</div>
			</section>
		</div>
		<!-- eof #box_wrapper -->
	</div>
	<!-- eof #canvas -->

	<script src="js/compressed.js"></script>
	<script src="js/main.js"></script>
	<script src="js/custom.js"></script>
    </div>
    </form>
</body>
</html>
