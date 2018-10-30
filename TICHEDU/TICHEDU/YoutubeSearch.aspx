<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YoutubeSearch.aspx.cs" Inherits="YoutubeSearchqa" %>


<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
<head>
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
	
	
	
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
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
   <form id="frm1" runat="server">
	<!--[if lt IE 9]>
		<div class="bg-danger text-center">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/" class="highlight">upgrade your browser</a> to improve your experience.</div>
	<![endif]-->
	<div class="preloader">
		<div class="preloader_image"></div>
	</div>

	<!-- search modal -->
	<div class="modal" tabindex="-1" role="dialog" aria-labelledby="search_modal" id="search_modal">
		<button type="button" class="close" data-dismiss="modal" aria-label="Close">
			<span aria-hidden="true">
				<i class="rt-icon2-cross2"></i>
			</span>
		</button>
		<div class="widget widget_search">
			<div class="searchform search-form form-inline" >
				<div class="form-group bottommargin_0">
					<input type="text" value="" name="search" class="form-control" placeholder="Search keyword" id="modal-search-input">
				</div>
				<button type="submit" class="theme_button">Search</button>
			</div>
		</div>
	</div>

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
						<div class="form-group">
							<label for="mailchimp" class="sr-only">Search here</label>
							<i class="flaticon-envelope icon2-"></i>
						<!--	<input name="" type="search" id="mailchimp" class="mailchimp_email form-control" placeholder="Search">
							<button type="submit" class="theme_button color1"><i class="fa fa-search"></i></button>-->
						</div>
					 </div>
					
						<div class="col-sm-6 text-center text-sm-right">
							<ul class="inline-list menu darklinks">
								<li>
									<asp:LinkButton ID="mycontent" class="fa fa-file" OnClick="mycontent_Click" runat="server">MY CONTENT</asp:LinkButton>
								</li>
								<li>
									 <asp:LinkButton ID="profile_click" class="fa fa-user" OnClick="Profile_link_button_Click" runat="server">PROFILE</asp:LinkButton>
								</li>
                                <li>
									
								   
										<asp:LinkButton ID="Upload_link_button" class="fa fa-upload" OnClick="Upload_link_button_Click" runat="server">UPLOAD</asp:LinkButton>
									   
								</li>
								<li>
									<asp:LinkButton ID="signout" class="fa fa-sign-out" OnClick="signout_Click" runat="server">SIGN OUT</asp:LinkButton>
								</li>
							</ul>
						</div>
					</div>
				</div>
			</section>


			<header class="page_header_side page_header_side_sticked active-slide-side-header ls">
				<span class="toggle_menu_side header-slide">
					<span></span>
				</span>
				<div class="scrollbar-macosx">
					<div class="side_header_inner">
						<div class="header-side-menu darklinks">
							<!-- main side nav start -->
							<nav class="mainmenu_side_wrapper">
							<a href="index.aspx" class="logo top_logo">
								<img src="images/logo.png" alt="">
							</a>	
								<ul class="nav menu-click">
									<li >
								   
									 <asp:LinkButton ID="Pdfnoteslink_btn"  OnClick="Pdfnoteslink_btn_Click" runat="server">TichEdu Pdf Notes</asp:LinkButton>
								
											</li>

									<li>
                                        <asp:LinkButton ID="Youtube_linkbtn" OnClick="Youtube_linkbtn_Click" runat="server">TichEdu YouTube</asp:LinkButton>
									</li>
									<li>
										<a href="AddQuestion.aspx">TichEdu Exams</a>
									</li>
									<li>
										 <asp:LinkButton ID="youtube_videos_link" OnClick="youtube_videos_link_Click" runat="server">TichEdu YouTube Videos</asp:LinkButton>
									</li>
									<li>
										<g:sharetoclassroom url="http://url-to-share" size="32"></g:sharetoclassroom>
                                        <asp:Label ID="Label1" runat="server" Text="Google Classroom"></asp:Label>
									</li>
                                    <li>
										 <asp:LinkButton ID="Groupchat" OnClick="Groupchat_Click" runat="server">TichEdu Group Chat</asp:LinkButton>
									</li>
                                      <li>
										 <asp:LinkButton ID="whiteboard" OnClick="whiteboard_Click" runat="server">TichEdu White Board</asp:LinkButton>
									</li>
                                     <li>
<asp:LinkButton ID="studentactivity" OnClick="studentactivity_Click" runat="server">TichEdu Student Activity</asp:LinkButton>
</li>
									<!-- eof pages -->
								</ul>
							</nav>
							<!-- eof main side nav -->
							
<!--<div class="container text-center">
	<div class="row">
        <div class="round hollow text-center">
        <a href="#" id="addClass"><span class="glyphicon glyphicon-comment"></span> Open in chat </a>
        </div>       
	</div>
</div>-->


						</div>
					</div>
				</div>
			</header>




			<section class="ls page_portfolio section_padding_top_10 section_padding_bottom_75">
				<div class="container">
					<div class="row">
						<div class="col-sm-12 col-md-12">
                               
                            <asp:TextBox ID="searchtextbox" runat="server"></asp:TextBox>
                            <asp:Button ID="Button1" OnClick="Button1_Click1" runat="server" Text="search" />
                            <div id="testinner" runat="server"></div>

                            </form>
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
     <script src="https://apis.google.com/js/platform.js" async defer></script>
	<script src="js/compressed.js"></script>
	<script src="js/main.js"></script>
	<script src="js/custom.js"></script>

</body>
</html>