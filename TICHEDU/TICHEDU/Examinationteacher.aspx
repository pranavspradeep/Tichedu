<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Examinationteacher.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

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
    <form id="frm" runat="server">
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
				<i class="rt-icon2-cross2"></i>			</span>		</button>
		<div class="widget widget_search">
			<div method="get" class="searchform search-form form-inline" action="#">
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
							<input name="" type="search" id="mailchimp" class="mailchimp_email form-control" placeholder="Search">
							<button type="submit" class="theme_button color1"><i class="fa fa-search"></i></button>
						</div>
					 </div>
					  
						<div class="col-sm-6 text-center text-sm-right">
							<ul class="inline-list menu darklinks">
								<li>
									<a href="#"><i class="fa fa-file"></i> MY CONTENT</a>								</li>
								<li>
									<a href="#"><i class="fa fa-user"></i> PROFILE</a>								</li>
								<li>
									<a href="#"><i class="fa fa-sign-out"></i> SIGN OUT</a>								</li>
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
								   
									 <a id="Pdfnoteslink_btn" href="javascript:__doPostBack(&#39;Pdfnoteslink_btn&#39;,&#39;&#39;)">Pdf Notes</a>											</li>

									<li>
                                        <a id="Youtube_linkbtn" href="javascript:__doPostBack(&#39;Youtube_linkbtn&#39;,&#39;&#39;)">YouTube</a>									</li>
									<li>
										<a href="AddQuestion.aspx">Exams</a>									</li>
                                    <li>
                                        <a id="youtubevideos" href="javascript:__doPostBack(&#39;youtubevideos&#39;,&#39;&#39;)">YouTube videos</a>									</li>

								<!-- eof pages -->
								</ul>
							</nav>
							<!-- eof main side nav -->
							
<div class="container text-center">
	<div class="row">
        <div class="round hollow text-center">
        <a href="#" id="addClass"><span class="glyphicon glyphicon-comment"></span> Open in chat </a>        </div>       
	</div>
</div>
						</div>
					</div>
				</div>
			</header>




			<section class="ls page_portfolio section_padding_top_10 section_padding_bottom_75">
				<div class="container">
					<div class="row">
						<div class="col-sm-12 col-md-12">



                <div class="container">
                <div class="">
                    
                    <p class="text-danger">Class</p>
                    <asp:DropDownList ID="Class_dropdown" CssClass="form-control" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Class_dropdown_SelectedIndexChanged"></asp:DropDownList>
                     



                    
                   <!-- <select name="Class_dropdown" onchange="javascript:setTimeout(&#39;__doPostBack(\&#39;Class_dropdown\&#39;,\&#39;\&#39;)&#39;, 0)" id="Class_dropdown" class="form-control">
	<option selected="selected" value="NA">Select</option>
	<option value="I         ">I         </option>
	<option value="II        ">II        </option>
	<option value="III       ">III       </option>
	<option value="IV        ">IV        </option>
	<option value="V         ">V         </option>
	<option value="VI        ">VI        </option>
	<option value="VII       ">VII       </option>
	<option value="VIII      ">VIII      </option>
	<option value="IX        ">IX        </option>
	<option value="X         ">X         </option>
	<option value="XI        ">XI        </option>
	<option value="XII       ">XII       </option>
	<option value="DEGREE    ">DEGREE    </option>
	<option value="PG        ">PG        </option>

</select>--->
                    <p class="text-danger">Subject</p>

                   

                     <asp:DropDownList ID="Subject_dropdown" CssClass="form-control"   runat="server" ></asp:DropDownList>
                 <!--   <select name="Subject_dropdown" id="Subject_dropdown" class="form-control">
	<option selected="selected" value="NA">Select</option>
	<option value="NA">Select</option>
	<option value="MATHEMATICS">MATHEMATICS</option>
	<option value="COMPUTER">COMPUTER</option>
	<option value="PHYSICS">PHYSICS</option>
	<option value="CHEMISTRY">CHEMISTRY</option>
	<option value="BIOLOGY">BIOLOGY</option>
	<option value="HUMANITIES">HUMANITIES</option>
	<option value="COMMERCE">COMMERCE</option>
</select>--->
                    <p class="text-danger">Exam name</p>
                      <asp:DropDownList ID="Exam_drop" CssClass="form-control" runat="server" ></asp:DropDownList>
                 <!--   <select name="Exam_drop" id="Exam_drop" class="form-control">
	<option value="NA">Select</option>
	<option value="FIRST TERM">FIRST TERM</option>

</select>---->
                    <p class="text-danger">Question</p>
                    <asp:TextBox ID="Question_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                  <!--  <input name="Question_txtbox" type="text" id="Question_txtbox" class="form-control" />--->
                    <p class="text-danger">Option 1</p>
                     <asp:TextBox ID="option1_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                 <!--   <input name="option1_txtbox" type="text" id="option1_txtbox" class="form-control" />--->
                    <p class="text-danger">Option 2</p>
                     <asp:TextBox ID="option2_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                  <!--  <input name="option2_txtbox" type="text" id="option2_txtbox" class="form-control" />--->
                     <p class="text-danger">Option 3</p>
                     <asp:TextBox ID="option3_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                 <!--   <input name="option3_txtbox" type="text" id="option3_txtbox" class="form-control" />--->
                     <p  class="text-danger">Option 4</p>
                     <asp:TextBox ID="option4_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                  <!--  <input name="option4_txtbox" type="text" id="option4_txtbox" class="form-control" />--->
                    <p class="text-danger">Answer</p>
                     <asp:TextBox ID="Answer_txtbox" CssClass="form-control" runat="server"></asp:TextBox>
                   <!---  <input name="Answer_txtbox" type="text" id="Answer_txtbox" class="form-control" />--->
                    <p class="text-danger"> </p>
                 <!--   <input type="submit" name="Sub_btn" value="Submit" id="Sub_btn" class="form-control" />--->
                    <asp:Button ID="submit" OnClick="Sub_btn_Click" runat="server" Text="Submit" />
                        </form>
                    <span id="message" style="color:Red;"></span> </div>
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
</body>
</html>