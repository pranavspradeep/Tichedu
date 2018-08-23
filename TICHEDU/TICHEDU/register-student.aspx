<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register-student.aspx.cs" Inherits="register_student" %>

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
	<link rel="stylesheet" href="css/custom.css">
	<script src="js/vendor/modernizr-2.6.2.min.js"></script>

	<!--[if lt IE 9]>
		<script src="js/vendor/html5shiv.min.js"></script>
		<script src="js/vendor/respond.min.js"></script>
		<script src="js/vendor/jquery-1.12.4.min.js"></script>
	<![endif]-->

</head>

<body>

    <form id="MAINFORM" runat="server">


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
								<a href="index.html" class="logo top_logo">
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

						<div class="col-md-12 to_animate" data-animation="scaleAppear">

							<h3>Student Registration</h3>
                            <asp:HyperLink ID="sucess" NavigateUrl="~/login-student.aspx" runat="server" ForeColor="Red">REGISTRATION SUCESSFULL "CLICK TO LOGIN"</asp:HyperLink>
							 <asp:Label ID="errormsg" runat="server" Text=""></asp:Label>  
                            <form class="contact-form row columns_padding_10"  method="post" action="#">
								<div class="col-sm-6">
									<label>First Name<span class="required" autofocus required></span>
</label>
									<input id="Firstname_txtbox" type="text" runat="server" class="form-control" required>
								</div>
								<div class="col-sm-6">
									<label>Last Name<span class="required"></span>
</label>
									<input type="text" id="Lastname_txtbox" runat="server" class="form-control" required>
								</div>
								
								<div class="col-sm-6">
									<label>DOB</label>
									<input type="date" id="Dob_txtbox" runat="server" class="form-control" required>
								</div>
								<div class="col-sm-6">
									<label>Sex</label>
									<select id="Sex_txtbox" runat="server" class="wide form-control" required>
										<option value="0">Sex</option>
										<option value="1">Male</option>
										<option value="2">Female</option>
									</select>
								</div>
								
								
								<div class="col-sm-6">
									<label>Studying in</label>
									<input type="text" id="Studyingin_txtbox" runat="server" class="form-control" required>
								</div>
								<div class="col-sm-6">
									<label>Specialization</label>
									<input type="text" id="Special_txtbox" runat="server" class="form-control" required>
								</div>

								
								
								<div class="col-sm-6">
									<label>Email<span class="required"></span>
</label>
									<input type="text" id="Email_txtbox" runat="server" required pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" title="Enter valid email" class="form-control">
								</div>
								<div class="col-sm-6">
									<label>Contact<span class="required"></span>
</label>
									<input type="text" id="Contact_txtbox" required title="10 digit mobile number " pattern="[0-9]{10}" runat="server" class="form-control">
								</div>


								
								

								<div class="col-sm-4">
									<label>Address</label>
									<textarea rows="4" id="Address_txtbox" runat="server" cols="40" type="text" class="form-control" required></textarea>
								</div>
								<div class="col-sm-4">
									<label>Country</label>
									<input type="text" id="Country_txtbox" runat="server" class="form-control" required>
								</div>
								<div class="col-sm-4">
									<label> City</label>
									<input type="text" id="City_txtbox"  runat="server" class="form-control" required>
								</div>
								<div class="col-sm-4">
									<label> Street</label>
									<input type="text" id="Street_txtbox" runat="server" class="form-control" required>
								</div>
								<div class="col-sm-4">
									<label> Zip</label>
									<input type="number" id="Zip_txtbox" runat="server" class="form-control" required>
								</div>
								
								
								
								<!--<div class="col-sm-6">
									<label> Username</label>
									<input type="text" id="Username_txtbox" runat="server" class="form-control">
								</div>--->
								<div class="col-sm-6">
									<label> Password</label>
									<input type="password" id="Password_txtbox" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" title="Must contain at least one number and one uppercase and lowercase letter, and at least 8 or more characters" runat="server" class="form-control" required>
								</div>
								
								
								<div class="col-sm-6">
									<label>Where you here about tichedu</label>
									<textarea rows="3" cols="10" id="Whereyhere"  runat="server" type="text" class="form-control"></textarea>
								</div>
								<div class="col-sm-2">
										<div class="media-left media-middle" style="padding-left:40px; padding-top:20px;">
											<img src="images/dp.png" alt="" />
										</div>
								</div>
								
								<div class="col-sm-4">
									<label> Upload Your Photo</label>
									<asp:FileUpload ID="file" runat="server"  accept="image/*"  />
                                   
								</div>

								

								
								
								
								
								
		
								
                                
								<div class="col-sm-12">

									<div class="contact-form-submit topmargin_10">

                                        <asp:Button ID="contact_form_submit" OnClick="contact_form_submit_ServerClick" runat="server" Text="Register" class="theme_button color2 wide_button" />
										
									</div>
								</div>


							</form>
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

</form>
</body>
</html>
