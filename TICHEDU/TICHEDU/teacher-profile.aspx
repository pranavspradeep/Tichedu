<%@ Page Language="C#" AutoEventWireup="true" CodeFile="teacher-profile.aspx.cs" Inherits="student_profile" %>

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
    <form id="mainform" runat="server">
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
										<li>
									<asp:LinkButton ID="Mycontent" class="fa fa-upload" OnClick="Mycontent_Click" runat="server">My Content</asp:LinkButton>
							
								</li>
								
								<li>
								  
								<asp:LinkButton ID="Profile_link_button" class="fa fa-upload" OnClick="Profile_link_button_Click" runat="server">PROFILE</asp:LinkButton>
							
										</li>
								
								<li>
									
								   
										<asp:LinkButton ID="Upload_link_button" class="fa fa-upload" OnClick="Upload_link_button_Click" runat="server">UPLOAD</asp:LinkButton>
									   
								</li>
									</ul>
								</nav>
								<!-- eof main nav -->
								<!-- header toggler -->
								<span class="toggle_menu">
									<span></span>
								</span>
							</div>

							<div class="header_right_buttons display_table_cell text-right hidden-xs ls">
								<ul class="inline-list menu darklinks">
									
									<li>
										<a href="login-teacher.aspx" class="small-text medium"><i class="fa fa-sign-out"></i>Sign out</a>
									</li>
									
								</ul>
							</div>
						</div>
					</div>
				</div>
			</header>




			
			<section class="page_breadcrumbs ds parallax section_padding_top_100 section_padding_bottom_100">
				<div class="container">
					<div class="row">
						<div class="col-sm-12 text-center">
							<h2 class="highlight2">
                                <asp:Label ID="Teacher_name_firstname" runat="server" Text="Label"></asp:Label>&nbsp;<asp:Label ID="Teacher_name_lastname" runat="server" Text="Label"></asp:Label></h2>
							<h4 class="breadcrumb darklinks"> <asp:Label ID="Teacher_Subject" runat="server" Text="Label"></asp:Label></h4>
							</ol>
						</div>
					</div>
				</div>
			</section>

			<section class="ls section_padding_top_50 section_padding_bottom_50 columns_padding_25">
				<div class="container">


					<div class="row">

						<div class="col-sm-7 col-md-8 col-lg-8">

							<!-- .post -->

							<article class="post format-small-image with_border ">

								<div class="side-item side-md content-padding big-padding">

									<div class="row">

										<div class="col-md-5">
											<div class="item-media entry-thumbnail">
                                                <form>
                                                    <img id="image_v" runat="server" alt="" src="imageIDtagName"  />
                                               </form>
												<div class="media-links color2">
													<a href="blog-single-right.html" class="abs-link"></a>
												</div>
												<div class="cs entry-meta media-meta vertical_gradient_bg_color text-center">
													<div class="side-media-links">
														<a href="blog-single-right.html">
															<i class="fa fa-edit" aria-hidden="true"></i>
														</a>
													</div>
												</div>
											</div>
										</div>

										<div class="col-md-7">
											<div class="item-content">

												<header class="entry-header">
													<h4 class="entry-title ">
														<a href="#" rel="bookmark">
                                                            <asp:Label ID="Name_2" runat="server" Text="Label"></asp:Label>&nbsp; <asp:Label ID="last_name2" runat="server" Text="Label"></asp:Label></a>
													</h4>
													<div class="entry-meta small-text medium content-justify">
														<span class="highlight2links">
															<a href="#">Subject:<asp:Label ID="subjects_label" CssClass="form-control" runat="server" Text="Label"></asp:Label></a>
														</span>
														<span class="greylinks">
															<a href="#">D.O.B:<asp:Label ID="Dateofbirth_label" CssClass="form-control" runat="server" Text="Label"></asp:Label></a>
														</span>
													</div>
												</header>

												<div class="entry-content">
                                                 Address:<asp:Label ID="Address" runat="server" CssClass="form-control" Text="Label"></asp:Label><br />
                                                 Country:<asp:Label ID="Country" runat="server" CssClass="form-control" Text="Label"></asp:Label><br />
                                                    City:<asp:Label ID="City" runat="server" CssClass="form-control" Text="Label"></asp:Label><br />
                                                    Street:<asp:Label ID="Street" runat="server" CssClass="form-control" Text="Label"></asp:Label><br />
                                                    Zip:<asp:Label ID="Zip" runat="server" CssClass="form-control" Text="Label"></asp:Label>

												</div>

											</div>
										</div>

									</div>
								</div>

							</article>
							<!-- .post -->
						
						
						<!--<hr>
						<div class="col-sm-12 col-md-12">
						<h3 class="widget-title">Recent Classes</h3>

							<div class="isotope_container isotope row masonry-layout columns_margin_bottom_20" data-filters=".isotope_filters">
								<div class="isotope-item col-lg-4 col-md-6 col-sm-12 books">
									<article class="vertical-item content-padding post format-standard with_border text-center">

										<div class="item-media">

											<img src="images/gallery/03.jpg" alt="">

											<div class="media-links">
												<a href="https://youtu.be/kFLam8HVY4w" class="abs-link prettyPhoto" title="" data-gal="prettyPhoto[gal]"></a>
											</div>
										</div>

										<div class="item-content">
											<header class="entry-header">
												<div class="small-text medium categories-links highlight2links">
													<a href="#">Video Name</a>
												</div>
											</header>
											
										</div>

									</article>
								</div>
								<div class="isotope-item col-lg-4 col-md-6 col-sm-12 cabinets">
									<article class="vertical-item content-padding post format-standard with_border  text-center">

										<div class="item-media">

											<img src="images/gallery/03.jpg" alt="">

											<div class="media-links">
												<a href="https://youtu.be/kFLam8HVY4w" class="abs-link prettyPhoto" title="" data-gal="prettyPhoto[gal]"></a>
											</div>
										</div>

										<div class="item-content">
											<header class="entry-header">
												<div class="small-text medium categories-links highlight2links">
													<a href="#">Video Name</a>
												</div>
											</header>
											
										</div>

									</article>
								</div>
								<div class="isotope-item col-lg-4 col-md-6 col-sm-12 courses">
									<article class="vertical-item content-padding post format-standard with_border  text-center">

										<div class="item-media">

											<img src="images/gallery/03.jpg" alt="">

											<div class="media-links color3">
												<a href="https://youtu.be/kFLam8HVY4w" class="abs-link prettyPhoto" title="" data-gal="prettyPhoto[gal]"></a>
											</div>
										</div>

										<div class="item-content">
											<header class="entry-header">
												<div class="small-text medium categories-links highlight2links">
													<a href="#">Video Name</a>
												</div>
											</header>
											
										</div>

									</article>
								</div>
							</div>
						</div>	

						</div>
						<!--eof .col-sm-8 (main content)-->

						<!-- sidebar -->
						<!--<aside class="col-sm-5 col-md-4 col-lg-4">
						

							<div class="widget widget_popular_courses">

								<h3 class="widget-title">Notifications</h3>
								<ul class="media-list">
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">
									Notification details here
								</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">11-06-2017 Sunday</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">
									Notification details here
								</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">10.30am</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">
									Notification details here
								</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">3.54pm</a>
							</p>
										</div>
									</li>
								</ul>
							</div>
						
						
						<hr>

							

							<div class="widget widget_popular_courses">

								<h3 class="widget-title">History</h3>
								<ul class="media-list">
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">History</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">History detail</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">History</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">History detail</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">History</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">History detail</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">History</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">History detail</a>
							</p>
										</div>
									</li>
									<li class="media">
										<div class="media-body media-middle">
											<h4 class="entry-title">
												<a href="#">History</a>
											</h4>
											<p class="small-text medium highlight2links">
								<a href="#0">History detail</a>
							</p>
										</div>
									</li>
								</ul>
							</div>
						
						
						<hr>

							


						</aside>
						<!-- eof aside sidebar 

					</div>
				</div>-->
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
	</form>
</body>
</html>