<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacher.aspx.cs" Inherits="teacher" %>


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

<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
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
			<form method="get" class="searchform search-form form-inline" action="#">
				<div class="form-group bottommargin_0">
					<input type="text" value="" name="search" class="form-control" placeholder="Search keyword" id="modal-search-input">
				</div>
				<button type="submit" class="theme_button">Search</button>
			</form>
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
							<!--<input name="" type="search" id="mailchimp" class="mailchimp_email form-control" placeholder="Search">
							<button type="submit" class="theme_button color1"><i class="fa fa-search"></i></button>-->
						</div>
					 </div>
					  <div class="col-sm-6 text-center text-sm-right">
							<ul class="inline-list menu darklinks">
								<li>
									<a href="#"><i class="fa fa-file"></i> My Content</a>
								</li>
								
								<li>
								  
								<asp:LinkButton ID="Profile_link_button" class="fa fa-upload" OnClick="Profile_link_button_Click" runat="server">PROFILE</asp:LinkButton>
							
										</li>
								
								<li>
									
								   
										<asp:LinkButton ID="Upload_link_button" class="fa fa-upload" OnClick="Upload_link_button_Click" runat="server">UPLOAD</asp:LinkButton>
									   
								</li>
								<li><a href="login-teacher.aspx" class="small-text medium"><i class="fa fa-sign-out"></i>Sign out</a></li>
                                <li><asp:Image ID="GoogleProfileimage" runat="server" Width="50" Height="50" /><asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                                    <asp:Label ID="id_label" runat="server" Text=""></asp:Label></li>
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
								   
									 <asp:LinkButton ID="Pdfnoteslink_btn"  OnClick="Pdfnoteslink_btn_Click" runat="server">Pdf Notes</asp:LinkButton>
								
											</li>

									<li>
                                        <asp:LinkButton ID="Youtube_linkbtn" OnClick="Youtube_linkbtn_Click" runat="server">YouTube</asp:LinkButton>
									</li>
									<li>
										<a href="AddQuestion.aspx">Exams</a>
									</li>
									<li>
										 <asp:LinkButton ID="youtube_videos_link" OnClick="youtube_videos_link_Click" runat="server">YouTube Videos</asp:LinkButton>
									</li>
									<li>
										<g:sharetoclassroom url="http://url-to-share" size="32"></g:sharetoclassroom>
                                        <asp:Label ID="Label1" runat="server" Text="Google Classroom"></asp:Label>
									</li>
                                    <li>
										 <asp:LinkButton ID="Groupchat" OnClick="Groupchat_Click" runat="server">Group Chat</asp:LinkButton>
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


<div class="popup-box chat-popup" id="qnimate">
			  <div class="popup-head">
				<div class="popup-head-left pull-left"><img src="http://bootsnipp.com/img/avatars/bcf1c0d13e5500875fdd5a7e8ad9752ee16e7462.jpg" > Gurdeep Osahan</div>
					  <div class="popup-head-right pull-right">
						<div class="btn-group">
									  <button class="chat-header-button" data-toggle="dropdown" type="button" aria-expanded="false">
									   <i class="glyphicon glyphicon-cog"></i> </button>
									  <ul role="menu" class="dropdown-menu pull-right">
										<li><a href="#">Media</a></li>
										<li><a href="#">Block</a></li>
										<li><a href="#">Clear Chat</a></li>
										<li><a href="#">Email Chat</a></li>
									  </ul>
						</div>
						
						<button data-widget="remove" id="removeClass" class="chat-header-button pull-right" type="button"><i class="glyphicon glyphicon-off"></i></button>
					  </div>
			  </div>
			<div class="popup-messages">
			
			
			
			
			<div class="direct-chat-messages">
					
					
					<div class="chat-box-single-line">
								<abbr class="timestamp">October 8th, 2015</abbr>
					</div>
					
					
					<!-- Message. Default to the left -->
					<div class="direct-chat-msg doted-border">
					  <div class="direct-chat-info clearfix">
						<span class="direct-chat-name pull-left">Osahan</span>
					  </div>
					  <!-- /.direct-chat-info -->
					  <img alt="message user image" src="http://bootsnipp.com/img/avatars/bcf1c0d13e5500875fdd5a7e8ad9752ee16e7462.jpg" class="direct-chat-img"><!-- /.direct-chat-img -->
					  <div class="direct-chat-text">
						Hey bro, how’s everything going ?
					  </div>
					  <div class="direct-chat-info clearfix">
						<span class="direct-chat-timestamp pull-right">3.36 PM</span>
					  </div>
						<div class="direct-chat-info clearfix">
						<span class="direct-chat-img-reply-small pull-left">
							
						</span>
						<span class="direct-chat-reply-name">Singh</span>
						</div>
					  <!-- /.direct-chat-text -->
					</div>
					<!-- /.direct-chat-msg -->
					
					
					<div class="chat-box-single-line">
						<abbr class="timestamp">October 9th, 2015</abbr>
					</div>
			
					
					
					<!-- Message. Default to the left -->
					<div class="direct-chat-msg doted-border">
					  <div class="direct-chat-info clearfix">
						<span class="direct-chat-name pull-left">Osahan</span>
					  </div>
					  <!-- /.direct-chat-info -->
					  <img  src="http://bootsnipp.com/img/avatars/bcf1c0d13e5500875fdd5a7e8ad9752ee16e7462.jpg" class="direct-chat-img"><!-- /.direct-chat-img -->
					  <div class="direct-chat-text">
						Hey bro, how’s everything going ?
					  </div>
					  <div class="direct-chat-info clearfix">
						<span class="direct-chat-timestamp pull-right">3.36 PM</span>
					  </div>
						<div class="direct-chat-info clearfix">
						  <img  src="http://bootsnipp.com/img/avatars/bcf1c0d13e5500875fdd5a7e8ad9752ee16e7462.jpg" class="direct-chat-img big-round">
						<span class="direct-chat-reply-name">Singh</span>
						</div>
					  <!-- /.direct-chat-text -->
					</div>
					<!-- /.direct-chat-msg -->
					
					
					

					

				  </div>
			
			
			
			
			
			
			
			
			
			</div>
			<div class="popup-messages-footer">
			<textarea id="status_message" placeholder="Type a message..." rows="10" cols="40" name="message"></textarea>
			<div class="btn-footer">
			<button class="bg_none"><i class="glyphicon glyphicon-film"></i> </button>
			<button class="bg_none"><i class="glyphicon glyphicon-camera"></i> </button>
			<button class="bg_none"><i class="glyphicon glyphicon-paperclip"></i> </button>
			<button class="bg_none pull-right"><i class="glyphicon glyphicon-thumbs-up"></i> </button>
			</div>
			</div>
	  </div>
						</div>
					</div>
				</div>
			</header>




			<section class="ls page_portfolio section_padding_top_10 section_padding_bottom_75">
				
             
        
                    <asp:DataList ID="DataListvideo" runat="server" cssClass="row" RepeatLayout="Flow" RepeatDirection="Horizontal">
                          <ItemTemplate>
                          <div class="col-sm-3 col-md-3 col-lg-3"><div class="embed-responsive  embed-responsive-4by3" ><video  id="VideoPlayer" controls="controls"  class="embed-responsive-item" >
			                    	<source src='<%# Eval("VIDEO_ID", "FileCS.ashx?Id={0}") %>' type="video/mp4">

				
					</video></div><div class="p-3 mb-2 bg-danger text-white" >TITLE:<%# Eval("VIDE0_TITLE") %></div>

                                 <div class="p-3 mb-2 bg-danger text-white ">VIDEO FRO CLASS:<%# Eval("VIDEO_FOR_CLASS") %></div>    
                                <div class="p-3 mb-2 bg-danger text-white ">SUBJECT:<%# Eval("VIDEO_SUBJECT") %></div>


                          </div>
         
            
        </ItemTemplate>
    </asp:DataList>

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
</form>
</body>
</html>
