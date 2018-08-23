<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

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



    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" type="text/css" href="sld/layerslider/css/layerslider.css">
    <link rel="stylesheet" href="sld/css/owl.carousel.min.css">

	<!-- Place favicon.ico and apple-touch-icon.png in the root directory -->

	<link rel="stylesheet" href="css/bootstrap.min.css">
	<link rel="stylesheet" href="css/animations.css">
	<link rel="stylesheet" href="css/fonts.css">
	<link rel="stylesheet" href="css/main.css" class="color-switcher-link">
	<link rel="stylesheet" href="css/shop.css">
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

			<!-- template sections -->

			<section class="page_topline ls ms table_section visible-xs">
				<div class="container">
					<div class="row">
						<div class="col-sm-12 text-center">

							<ul class="inline-list menu darklinks">
								<li>
									<div class="dropdown login-dropdown">
										<a href="#" id="topline-login" data-target="#" data-toggle="dropdown" class="small-text">Login</a>
										<div class="dropdown-menu" aria-labelledby="topline-login">

											<form>

												<div class="form-group has-placeholder">
													<label for="topline-login-email">Email address</label>
													<input type="email" class="form-control" id="topline-login-email" placeholder="Email Address">
												</div>


												<div class="form-group has-placeholder">
													<label for="topline-login-password">Password</label>
													<input type="password" class="form-control" id="topline-login-password" placeholder="Password">
												</div>

												<div class="content-justify divider_20">
													<div class="checkbox margin_0">
														<input type="checkbox" id="topline-remember_me_checkbox">
														<label for="topline-remember_me_checkbox" class="grey">Rememrber Me
														</label>
													</div>

													<a href="#">
                                            Lost password?
                                        </a>
												</div>


												<button type="submit" class="theme_button block_button color1">Log In</button>
											</form>

											<p class="topmargin_10 text-center grey highlightlinks">
                                    Not a member yet? <a href="shop-register.html">Register now</a>
                                </p>

										</div>
									</div>
								</li>
								<li>
									<a href="#" class="small-text">Sign up</a>
								</li>
							</ul>

						</div>
					</div>
				</div>
			</section>


			<header class="page_header header_white toggler_xs_right">
				<div class="container-fluid">
					<div class="row">
						<div class="col-sm-12 display_table">
							<div class="header_left_logo display_table_cell">
								<a href="index.aspx" class="logo top_logo">
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

							<div class="header_right_buttons display_table_cell text-right ls">
								<ul class="inline-list menu darklinks">
									
									<li>
										<div class="dropdown cart-dropdown">
											<a href="#" id="cart" data-target="#" data-toggle="dropdown" title="View your shopping cart" class="cart-contents small-text header-button">
												<i class="fa fa-sign-in" aria-hidden="true"></i> Login
											</a>
											<div class="dropdown-menu widget_shopping_cart">
												<div class="widget_shopping_cart_content">
													<p class="buttons content-justify">
                                        <a href="login-student.aspx" class="theme_button color1 inverse">Student</a>
                                        <a href="login-teacher.aspx" class="theme_button color1">Teacher</a>
                                    </p>
												</div>
											</div>
										</div>
									</li>

									<li>
										<div class="dropdown cart-dropdown">
											<a href="#" id="cart" data-target="#" data-toggle="dropdown" title="View your shopping cart" class="cart-contents small-text header-button">
												<i class="fa fa-sign-up" aria-hidden="true"></i> Sign Up
											</a>
											<div class="dropdown-menu widget_shopping_cart">
												<div class="widget_shopping_cart_content">
													<p class="buttons content-justify">
                                        <a href="register-student.aspx" class="theme_button color1 inverse">Student</a>
                                        <a href="register-teacher.aspx" class="theme_button color1">Teacher</a>
                                    </p>
												</div>
											</div>
										</div>
									</li>```

								</ul>
							</div>
						</div>
					</div>
				</div>
			</header>



            <section id="slider">
                <div id="full-slider-wrapper">
                    <div id="layerslider" style="width:100%;height:500px;">
                        <div class="ls-slide" data-ls="transition2d:1;timeshift:-1000;">
                            <img src="sld/images/sliderimages/bg.png" class="ls-bg" alt="Slide background"/>
                            <h3 class="ls-l" style="left:50px; top:135px; padding: 15px; color: #444444;font-size: 24px;font-family: 'Open Sans'; font-weight: bold; text-transform: uppercase;" data-ls="offsetxin:0;durationin:2500;delayin:500;durationout:750;easingin:easeOutElastic;rotatexin:90;transformoriginin:50% bottom 0;offsetxout:0;rotateout:-90;transformoriginout:left bottom 0;">Make any </h3>
                            <h1 class="ls-l" style="left: 63px; top:185px;background: #e96969;padding:0 10px; opacity: 1; color: #ffffff; font-size: 36px; font-family: 'Open Sans'; text-transform: uppercase; font-weight: bold;" data-ls="offsetxin:left;durationin:3000; delayin:800;durationout:850;rotatexin:90;rotatexout:-90;">video your lesson</h1>
                            <p class="ls-l" style="font-weight:600;left:62px; top:250px; opacity: 1;width: 450px; color: #444; font-size: 14px; font-family: 'Open Sans';" data-ls="offsetyin:top;durationin:4000;rotateyin:90;rotateyout:-90;durationout:1050;">Pick a video, add your magical touch and track your students' understanding</p>
                            <a href="#" class="ls-l button" style="border-radius:4px;text-align:center;left:63px; top:315px;background: #444;color: #ffffff;font-family: 'Open Sans';font-size: 14px;display: inline-block; text-transform: uppercase; font-weight: bold;" data-ls="durationout:850;offsetxin:90;offsetxout:-90;duration:4200;fadein:true;fadeout:true;">Sign up</a>
                            <img class="ls-l" src="sld/images/sliderimages/layer1.png" alt="layer 1" style="top:55px; left:700px;" data-ls="offsetxin:right;durationin:3000; delayin:600;durationout:850;rotatexin:-90;rotatexout:90;">
                            <img class="ls-l ls-linkto-2" style="top:400px;left:50%;white-space: nowrap;" data-ls="offsetxin:-50;delayin:1000;rotatein:-40;offsetxout:-50;rotateout:-40;" src="sld/images/sliderimages/left.png" alt="">
                            <img class="ls-l ls-linkto-2" style="top:400px;left:52%;white-space: nowrap;" data-ls="offsetxin:50;delayin:1000;offsetxout:50;" src="sld/images/sliderimages/right.png" alt="">
                        </div>
                        <div class="ls-slide" data-ls="transition2d:1;timeshift:-1000;">
                            <img src="sld/images/sliderimages/bg2.png" class="ls-bg" alt="Slide background"/>
                            <h1 class="ls-l" style="left: 50%; top:200px;background: #e96969;padding:0 10px; opacity: 1; color: #ffffff; font-size: 36px; font-family: 'Open Sans'; text-transform: uppercase; font-weight: bold;" data-ls="offsetxin:left;durationin:3000; delayin:800;durationout:850;rotatexin:90;rotatexout:-90;">Reinforce accountability</h1>
                            <p class="ls-l" style="text-align:center; font-weight:600;left:50%; top:265px; opacity: 1;width: 450px; color: #444; font-size: 14px; font-family: 'Open Sans';" data-ls="offsetyin:top;durationin:4000;rotateyin:90;rotateyout:-90;durationout:1050;">Know if your students are watching your videos, how many times per section and if they're understanding the content</p>
                            <img class="ls-l ls-linkto-1" style="top:400px;left:50%;white-space: nowrap;" data-ls="offsetxin:-50;delayin:1000;rotatein:-40;offsetxout:-50;rotateout:-40;" src="sld/images/sliderimages/left.png" alt="">
                            <img class="ls-l ls-linkto-1" style="top:400px;left:52%;white-space: nowrap;" data-ls="offsetxin:50;delayin:1000;offsetxout:50;" src="sld/images/sliderimages/right.png" alt="">
                        </div>
                    </div>
                </div>
            </section><!--end slider-->




			<section class="ls section_padding_top_100 section_padding_bottom_100 columns_margin_bottom_30 columns_padding_25 table_section table_section_md">
				<div class="container">
					<div class="row">
						<div class="col-md-6">
							<div class="with_pos_button left_button">
								<img src="images/ab1.png" alt="" />
							</div>
						</div>
						<div class="col-md-6">
							<h2 class="section_header highlight">
								Make any video your lesson
							</h2>
							<p>
					Pick a video, add your magical touch and track your students' understanding
				</p>
							<p class="topmargin_30">
					<a href="#" class="read-more">Sign up</a>
				</p>
						</div>
					</div>
				</div>
			</section>
			
			<section class="ls section_padding_top_100 section_padding_bottom_100 columns_margin_bottom_30 columns_padding_25 table_section table_section_md">
				<div class="container">
					<div class="row">
						<div class="col-md-6">
							<h2 class="section_header highlight">
								Reinforce accountability
							</h2>
							<p>
					Know if your students are watching your videos, how many times per section and if they're understanding the content
				</p>
							<p class="topmargin_30">
				</p>
						</div>
						
						
						<div class="col-md-6">
							<div class="with_pos_button left_button">
								<img src="images/ab2.png" alt="" />
							</div>
						</div>
					</div>
				</div>
			</section>

			<section class="ls section_padding_top_100 section_padding_bottom_100 columns_margin_bottom_30 columns_padding_25 table_section table_section_md">
				<div class="container">
					<div class="row">
						<div class="col-md-6">
							<div class="with_pos_button left_button">
								<img src="images/ab3.png" alt="" />
							</div>
						</div>
						<div class="col-md-6">
							<h2 class="section_header highlight">
								Engage students easily
							</h2>
							<p>
					Enable self-paced learning with interactive lessons, just add your voice and questions within the video.
				</p>
							<p class="topmargin_30">
				</p>
						</div>
					</div>
				</div>
			</section>
			
			<section class="ls section_padding_top_100 section_padding_bottom_100 columns_margin_bottom_30 columns_padding_25 table_section table_section_md">
				<div class="container">
					<div class="row">
						<div class="col-md-6">
							<h2 class="section_header highlight">
								Save time
							</h2>
							<p>
					Take already existing videos from YouTube, Khan Academy, Crash Course… or upload your own.
				</p>
							<p class="topmargin_30">
				</p>
						</div>
						
						
						<div class="col-md-6">
							<div class="with_pos_button left_button">
								<img src="images/ab4.png" alt="" />
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


</body>
</html>
