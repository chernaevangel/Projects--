<?php
    spl_autoload_register('myAutoloader');

    function myAutoloader($className)
    {
        $path = 'include/';

        include $path.$className.'.php';
    }

    session_start();
    
    $dbHandler = new DBHandler();

    $user = unserialize($_SESSION['loggedInEmployee']);

    if(count($_POST) > 0) {
        $fullname = $_POST['full_name'];
        $birthday = $_POST['birthday'];
        $phoneNumber = $_POST['phone_number'];
        $email = $_POST['email'];

        $splitname = explode(" ", $fullname);
        $firstName = $splitname[0];
        unset($splitname[0]);
        $lastName = implode(" ", $splitname);

        $user->ModifyEmployee($firstName, $lastName, $birthday, $phoneNumber, $email);
        $dbHandler->UpdateEmployee($user);
        
        $_SESSION['loggedInEmployee'] = serialize($user);
        Header("Location:profile.php");
    }
?>

<!DOCTYPE html>
<html>
    <head>
        <link rel="stylesheet" href="CSS/edit_profile.css"> 
    </head>
    <body>
        <?php
        if(count($_SESSION) > 0)
        {
            if($_SESSION['loggedInEmployee']) { ?>

                <div class="page">
                    <div class="editProfile">
                            <h1><span id="info">Edit details</span></h1>

                            <form name="edit_details" action="" method="post">
                                <label>Name: </label>
                                <input type="text" name="full_name" value="<?php echo $user->FirstName() . " " . $user->LastName(); ?>">
                                <br>
                                <br>
                                <label>Birthday: </label>
                                <input type="text" name="birthday" value="<?php echo $user->Birthday(); ?>">
                                <br>
                                <br>
                                <label>Phone number: </label>
                                <input type="text" name="phone_number" value="<?php echo $user->PhoneNumber(); ?>">
                                <br>
                                <br>
                                <label>Email: </label>
                                <input type="text" name="email" value="<?php echo $user->Email();  ?>">
                                <br>
                                <br>
                                <input type="submit" name="submit_edits" value="Save changes">
                                <button type="button" onclick="window.location.href='profile.php';">Cancel changes</button>
                            </form>
                            
                    </div>
                </div>
                
            <?php
            }
            else
            { Header("Location:index.php"); }
        }
        else
        {  Header("Location:index.php");  }
        ?>
    </body>
</html>