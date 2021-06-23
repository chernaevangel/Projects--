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

    $message="";

    if(count($_POST) > 0)
    {
        $firstName = $_POST["firstName"];
        $lastName = $_POST["lastName"];
        $birthday = $_POST["birthday"];
        $phoneNumber = $_POST["phoneNumber"];
        $employeeType = $_POST["employeeTypes"];
        $department = $_POST["departments"];
        $email = $_POST["email"];
        $password = $_POST["password"];

        try
        {
            if($dbHandler->registerEmployee($firstName, $lastName, $birthday, $phoneNumber, $employeeType, $department, $email, $password) == false)
            {
                $message = "A user with this email already exists!";
            }
            else
            {
                $message = "";
            }
        }
        catch (Exception $ex)
        {
            echo $ex->getMessage();
        }
    }

?>
<!DOCTYPE html>
<html>
    <head>
        <link rel="stylesheet" href="CSS/register.css"> 
    </head>
    <body>
        <?php
            if(count($_SESSION) > 0)
            {
                if($_SESSION['loggedInEmployee']) 
                {
                    if($user->EmployeeType() == "HR") {
                    ?>
                        <div class="formContainer">
                            <h1>Register new employee</h1>
                            <form name="frmRegister" action="" method="post">
                                <h4>Name:</h4> 
                                <input type="text" id="firstName" name="firstName" placeholder="First name" required>
                                <input type="text" id="lastName" name="lastName" placeholder="Last name" required>
                                <h4>Birthday:</h4>
                                <input type="text" name="birthday" placeholder="YYYY-MM-DD"required>
                                <h4>Phone number:</h4>
                                <input type="text" name="phoneNumber" required>
                                <h4>Employee Type:</h4>
                                <select id="employeeTypes" name="employeeTypes">
                                    <?php
                                        foreach($dbHandler->GetEmployeeTypes() as $empType) {
                                            echo '<option value="'.$empType.'">'.$empType.'</option>';
                                        }
                                    ?>
                                </select>
                                <h4>Department:</h4>
                                <select id="departments" name="departments">
                                    <?php
                                        foreach($dbHandler->GetDepartments() as $department) {
                                            echo '<option value="'.$department.'">'.$department.'</option>';
                                        }
                                    ?>
                                </select>
                                <h4>Email:</h4>
                                <input type="text" name="email" required>
                                <h4>Password:</h4>
                                <input type="text" name="password" required>
                                <br>
                                <?php if($message != "")
                                { echo '<h3 id="failMessage">'.$message.'</h3>'; }
                                ?>
                                <br>
                                <input type="submit" name="submit" value="Register user">
                                <button type="button" onclick="document.location='index.php'">Back to homepage</button>
                            </form>
                            <br>
                        </div>
                    <?php
                    }
                    else
                    { echo '<h1> Only managers can access this page! Click <a href="profile.php">here</a> to go back!</h1>'; }
                }
                else
                { echo Header("Location:index.php"); }
            }
            else
            {  Header("Location:index.php");  }
            ?>
    </body>
</html>