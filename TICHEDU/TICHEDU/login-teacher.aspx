<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login-teacher.aspx.cs" Inherits="login_teacher" %>

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
   <meta name="google-signin-client_id" content="556887803694-fml1vk4nh1geg2thcogdnhl9h66mcunq.apps.googleusercontent.com">
    <script src="https://apis.google.com/js/platform.js" async defer></script>

	<link href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800' rel='stylesheet' type='text/css'>
	<link rel="stylesheet" type="text/css" href="sld/layerslider/css/layerslider.css">
	<link rel="stylesheet" href="sld/css/owl.carousel.min.css">

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

<body>
	<!--[if lt IE 9]>
		<div class="bg-danger text-center">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/" class="highlight">upgrade your browser</a> to improve your experience.</div>
	<![endif]-->

	<div class="preloader">
		<div class="preloader_image"></div>
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
			<header class="page_header header_white toggler_xs_right">
				<div class="container-fluid">
					<div class="row">
						<div class="col-sm-12 display_table">
							<div class="header_left_logo display_table_cell">
								<a href="Index.aspx" class="logo top_logo">
									<img src="images/logo.png" alt="">
								</a>
							</div>

							<div class="header_mainmenu display_table_cell text-center">
								<!-- main nav start -->
								<nav class="mainmenu_wrapper">
									<ul class="mainmenu nav sf-menu">
										<li class="active"><a href="index.aspx">Home</a></li>
										<li><a href="login-student.aspx">Student Login</a></li>
										<li><a href="login-teacher.aspx">Teacher Login</a></li>
                                         <li><a href="login-parents.aspx">Parent  Login</a></li>
									</ul>
								</nav>
								<!-- eof main nav -->
								<!-- header toggler -->
								<span class="toggle_menu">
									<span></span>
								</span>
							</div>
						</div>
					</div>
				</div>
			</header>




			<section class="ls columns_padding_25 section_padding_top_75 section_padding_bottom_100">
				<div class="container">
					<div class="row">

						<div class="col-md-12 to_animate" data-animation="scaleAppear" >
							<div class="col-sm-8">
							<img src="images/tr.jpg" alt="">
							</div>
							<div class="col-sm-4">
							<h3>Teacher Login</h3>
												<form runat="server" id="Login_teacher_form">

													<div class="form-group has-placeholder">
														<label for="login-email">Email address</label>
														<input type="email" runat="server" class="form-control" id="login_email" placeholder="Email Address">
													</div>


													<div class="form-group has-placeholder">
														<label for="login-password">Password</label>
														<input type="password" runat="server" class="form-control" id="login_password" placeholder="Password">
													</div>

													<div class="content-justify divider_20">
														<div class="checkbox margin_0">
                                                           
															<input type="checkbox" id="remember_me_checkbox">
															<label for="remember_me_checkbox" class="grey">Rememrber Me
															</label> 
														</div>
                                                      
														<a href="#" aria-expanded="false">Lost password?</a>
													</div>
													<asp:Button ID="Submit_teacher_login" OnClick="Submit_teacher_login_Click" runat="server" class="theme_button block_button color1" Text="Log In" />
													  <asp:Label ID="Error_label" runat="server" ForeColor="Red" Text=""></asp:Label>
													<div class="side_header_social">
													
														
															
                                                       
														<asp:Button ID="Button1" runat="server" Text="Login With Gmail" CssClass="gmailbutton" OnClick="btnlogin_Click" />
                                                       
													
													</div>
												</form>
                                                 
												<p class="topmargin_10 text-center grey highlightlinks">Not a member yet? <a href="register-teacher.aspx">Register now</a></p>
							</div>
							
						</div>
						<!--.col-* -->


					</div>
					<!--.row -->

				</div>
				<!--.container -->
                

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
	
	
	<!-- script files -->
<script src="sld/bower_components/what-input/what-input.js"></script>
<script src="sld/bower_components/foundation-sites/dist/foundation.js"></script>
<script src="sld/js/jquery.showmore.src.js" type="text/javascript"></script>
<script src="sld/js/app.js"></script>
<script src="sld/layerslider/js/greensock.js" type="text/javascript"></script>
<!-- LayerSlider script files -->
<script src="sld/layerslider/js/layerslider.transitions.js" type="text/javascript"></script>
<script src="sld/layerslider/js/layerslider.kreaturamedia.jquery.js" type="text/javascript"></script>
<script src="sld/js/owl.carousel.min.js"></script>
<script src="sld/js/inewsticker.js" type="text/javascript"></script>
<script src="sld/js/jquery.kyco.easyshare.js" type="text/javascript"></script>
<!---google---->
    

   


</body>
</html>