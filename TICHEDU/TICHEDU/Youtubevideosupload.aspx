﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Youtubevideosupload.aspx.cs" Inherits="Youtubevideosupload" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->
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
	
	
	


	<!--[if lt IE 9]>
		<script src="js/vendor/html5shiv.min.js"></script>
		<script src="js/vendor/respond.min.js"></script>
		<script src="js/vendor/jquery-1.12.4.min.js"></script>
	<![endif]-->


</head>
    <style>
        /* SlideShow styles */
        
        .slideTitle
        {
            font-weight: bold;
            font-size: small;
            font-style: italic;
        }
        
        .slideDescription
        {
            font-size: small;
            font-weight: bold;
        }
        
        .validatorCalloutHighlight
        {
            background-color: lemonchiffon;
        }
        
        .ListSearchExtenderPrompt
        {
            font-style: italic;
            color: Gray;
            background-color: white;
        }
        
        .ajax__multi_slider_custom .outer_rail_horizontal
        {
            position: absolute;
            background: url('Images/rail_dark.gif') no-repeat;
            width: 321px;
            height: 25px;
            z-index: 100;
        }
        
        .ajax__multi_slider_custom .inner_rail_horizontal
        {
            position: absolute;
            background: url('Images/rail_light.gif') no-repeat;
            width: 321px;
            height: 25px;
            z-index: 100;
        }
        
        .ajax__multi_slider_custom .handle_horizontal_left
        {
            position: absolute;
            background: url('Images/handle_left.gif') no-repeat;
            width: 13px;
            height: 25px;
            z-index: 200;
            cursor: w-resize;
        }
        
        .ajax__multi_slider_custom .handle_horizontal_right
        {
            position: absolute;
            background: url('Images/handle_right.gif') no-repeat;
            width: 13px;
            height: 25px;
            z-index: 200;
            cursor: w-resize;
        }
    </style>
<body>
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
						<!--	<input name="" type="search" id="mailchimp" class="mailchimp_email form-control" placeholder="Search">
							<button type="submit" class="theme_button color1"><i class="fa fa-search"></i></button>--->
						</div>
					 </div>
					  
						<div class="col-sm-6 text-center text-sm-right">
							<ul class="inline-list menu darklinks">
								<li>
                                   <form runat="server">
                                    <asp:LinkButton id="Content_link" class="fa fa-file" OnClick="Content_link_Click" runat="server">MY CONTENT</asp:LinkButton>
								
                                       </li>
								
								<li>
                                   <asp:LinkButton id="Profile_link" class="fa fa-user" OnClick="Profile_link_Click" runat="server">PROFILE</asp:LinkButton>
								
									
								</li>
                                <li>
									
								   
										<asp:LinkButton ID="Upload_link_button" class="fa fa-upload" OnClick="Upload_link_button_Click" runat="server">UPLOAD</asp:LinkButton>
									   
								</li>
                                <li><a href="login-teacher.aspx" class="small-text medium"><i class="fa fa-sign-out"></i>Sign out</a></li>
								
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
										 <asp:LinkButton ID="youtube_videos_link" OnClick="Yotubevideos_Click" runat="server">YouTube Videos</asp:LinkButton>
									</li>
									<li>
										<g:sharetoclassroom url="http://url-to-share" size="32"></g:sharetoclassroom>
                                        <asp:Label ID="Label1" runat="server" Text="Google Classroom"></asp:Label>
									</li>
                                    <li>
										 <asp:LinkButton ID="Groupchat" OnClick="Groupchat_Click" runat="server">Group Chat</asp:LinkButton>
									</li>
                                      <li>
										 <asp:LinkButton ID="whiteboard" OnClick="whiteboard_Click" runat="server">White Board</asp:LinkButton>
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
</div>--->


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
            <!---VIDEO UPLOAD---PDF UPLOAD-->
              <div class="container">
                  <div class="jumbotron">
      <h3>YOUTUBE VIDEO UPLOAD</h3>
<p class=" text-danger">You Video Title(*):</p>	
    <asp:TextBox ID="Video_title" class="form-control" runat="server" ></asp:TextBox>
 
<p class=" text-danger">For Class(*):</p>
      <asp:DropDownList ID="classdrop" class="form-control"  AutoPostBack="true" runat="server"></asp:DropDownList>
 
           <p  class=" text-danger">Subject:(*):</p>
                <asp:DropDownList ID="subdrop" class="form-control" runat="server" AutoPostBack="true"></asp:DropDownList>
            
                      <!-----YOUTUBE PREVIEW AND TRIM--->
                      <iframe width="420" id="iframe" runat="server" height="315"  frameborder="0" allowfullscreen></iframe>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                      
                      <asp:TextBox  ID="TextBox3" runat="server"></asp:TextBox>
                      <ajaxToolkit:MultiHandleSliderExtender  ID="MultiHandleSliderExtender1"   HandleAnimationDuration="0.1"  EnableRailClick="true" Decimals="10" EnableInnerRangeDrag="true"  Minimum="0"  runat="server" TargetControlID="TextBox3" >
                <MultiHandleSliderTargets><ajaxToolkit:MultiHandleSliderTarget  ControlID="start"/></MultiHandleSliderTargets>
                             <MultiHandleSliderTargets><ajaxToolkit:MultiHandleSliderTarget  ControlID="end"/></MultiHandleSliderTargets>
            </ajaxToolkit:MultiHandleSliderExtender>
           <p id="startlabel" runat="server">Start</p> <asp:TextBox ID="start" runat="server"></asp:TextBox>
            <p id="endlabel" runat="server">End</p><asp:TextBox ID="end"  runat="server"></asp:TextBox><asp:Button ID="Trimbutton" runat="server" OnClick="Trimbutton_Click" Text="Trim" />

              
 <p  class=" text-danger">Youtube video id(*):</p>
                    
                      <asp:TextBox ID="YoutubeLink" class="form-control"  runat="server"></asp:TextBox>

 
                <div id="btnhelp" style="margin-top:5px">
                  <asp:Button ID="Upload_submit" class="theme_button color2" OnClick="Upload" runat="server" Text="Submit" />
                </div>
                    
                    
   <div >
             <p style="color:red;font-style:italic"><asp:Label ID="message" runat="server" Text=""></asp:Label></p>   </div>
                  </div>
                </div>
               
                

			</section>
  
       </form>
           
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
	
	<!-- eof #canvas -->
        <script src="https://apis.google.com/js/platform.js" async defer></script>
	<script src="js/compressed.js"></script>
	<script src="js/main.js"></script>
	<script src="js/custom.js"></script>

</body>
</html>

