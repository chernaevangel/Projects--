<?php

    spl_autoload_register('myAutoloader');

    function myAutoloader($className)
    {
        //$path = '/path/to/class/';
        $path = 'include/';

        include $path.$className.'.php';
    }

?>

<?php
    session_start();

    $message="";
    if(count($_POST) > 0) 
    {
        $dbHandler = new DBHandler();

        $email = $_POST["email"];
        $password = $_POST["password"];

        if ($dbHandler->getUser($email, $password))
        {
            $user = $dbHandler->getUser($email, $password);
            $_SESSION['loggedInEmployee'] = serialize($user);
        }
        else
        {
            $message = "Invalid Username or password!";
        }
    }
    if(isset($_SESSION['loggedInEmployee']))
    {
        Header("Location:profile.php");
    }
?>

<!DOCTYPE html>
<html>
<head>
    <link rel="stylesheet" href="CSS/index.css">  
</head>
<body>
<form class="log-in" action="" method="post">
  <div class="container">
    <label for="uname"><b>E-Mail</b></label>
    <input type="text" placeholder="Enter E-Mail" name="email" required value="<?php if(isset($_COOKIE["E-Mail"])) { echo $_COOKIE["E-Mail"]; } ?>">

    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" required>

    <button type="submit">Log in</button>
  </div>
  <div class="container">
    <p class="message"><?php if($message != "") {echo $message;} ?></p>
  <label>
      <input type="checkbox" checked="checked" name="remember"> Remember me
    </label>
  </div>
</form>
    </div>
</html>


