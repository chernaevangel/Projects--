<?php
session_start();
unset($_SESSION['loggedInEmployee']);

header("Location:index.php");
?>