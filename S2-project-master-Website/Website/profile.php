<?php
    spl_autoload_register('myAutoloader');

    function myAutoloader($className)
    {
        $path = 'include/';

        include $path.$className.'.php';
    }
?>

<?php
    session_start();
    
    $dbHandler = new DBHandler();

    $user = unserialize($_SESSION['loggedInEmployee']);

?>
<!DOCTYPE html>
<html>
    <head>
        <link rel="stylesheet" href="CSS/profile.css"> 
    </head>
    <body>
    <?php
        if(!empty($_POST["remember"])) {
            setcookie ("E-Mail",$user->Email(),time()+ 3600);
        }   
            else {
            setcookie("E-Mail","");
        }
        ?>
                <?php
            if(count($_SESSION) > 0)
            {
                if($_SESSION['loggedInEmployee']) {
                ?>
                    <div class="page">
                        <div class="employeeDetails">
                                <h1><span id="info">Personal details</span></h1>

                                <h4 id="title">Name: </h4>
                                <h4 id="details"><?php echo $user->FirstName() . " " . $user->LastName(); ?></h4>

                                <h4 id="title">Department: </h4>
                                <h4 id="details"><?php echo $user->Department(); ?></h4>

                                <h4 id="title">Birthday: </h4>
                                <h4 id="details"><?php echo $user->Birthday(); ?></h4>

                                <h4 id="title">Phone number: </h4>
                                <h4 id="details"><?php echo $user->PhoneNumber(); ?></h4>

                                <h4 id="title">Email: </h4>
                                <h4 id="details"><?php echo $user->Email();  ?></h4>

                                <?php
                                    if($user->EmployeeType() == "HR") {
                                        ?>
                                        <button class="register_employee" onclick="window.location.href='register_employee.php';">Register employee</button>
                                        <?php
                                    }
                                ?>  
                                <br>
                                <button class="edit_profile" onclick="window.location.href='edit_profile.php';">Edit profile</button>
                                <br><br>
                                <button class="logout" onclick="window.location.href='log_out.php';">Log out</button>
                        </div>
                        <div class="shifts">
                            <?php
                                $shifts = $user->Shifts();
                                ?>
                                <select class="select" size="25">
                                <option value="">Your Shifts:</option>
                                <option value="">Date / Shift time</option>
                                <?php
                                    if(is_array($shifts))
                                    {
                                        foreach($shifts as $shift)
                                        {
                                            echo "<option class='shiftInfo'>$shift</option>";
                                        }
                                    }
                                    else
                                    {
                                        echo "<option class='shiftInfo'>$shifts</option>";
                                    }                                
                            ?>
                            </select>
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

