<?php
include('classes.php');
if($_SERVER['REQUEST_METHOD']=='POST'){
  $con=new Connection();
  $reg=new RegCheck($_POST['uName'],$_POST['uPass'],$_POST['uFullName'],$_POST['uEmail']);
}
?>
<h1 class="text-center">Kérjük regisztráljon!</h1>
<form action="<?php echo $_SERVER['PHP_SELF'];?>?id=reglap" method="POST">
                    <div class="form-group">
                        <label for="inputUser">Felhasználónév</label>
                        <input value="Vastamaa1" name="uName" type="text" class="form-control" placeholder="Felhasználónév" required pattern="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$" title="Legalább egy kis-, nagybetűt, számot tartalmazzon, továbbá legalább 8 karakter hosszú legyen!">
                      </div>
                    <div class="form-group">
                        <label for="inputPw1">Jelszó</label>
                        <input value="Tamaska1234!" id="Password" name="uPass" type="password" class="form-control" id="inputPw1" placeholder="Jelszó" required pattern="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$" title="Legalább egy kis-, nagybetűt, számot, speciális karaktert tartalmazzon, továbbá legalább 8 karakter hosszú legyen!">
                      </div>
                      <div class="form-group">
                        <label for="inputPw2">Ismételt jelszó</label>
                        <input value="Tamaska1234!" id="ConfirmPassword" type="password" class="form-control" id="inputPw2" placeholder="Na, add meg megint a jelszót!" required pattern="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$" title="Legalább egy kis-, nagybetűt, számot, speciális karaktert tartalmazzon, továbbá legalább 8 karakter hosszú legyen!">
                      </div>
                      <div id="msg"></div><!--Jeszó vizsgálat eredményének a megjelenítése-->
                      <script>
                        //A két jeszó mező összehasonlítása
                        //Az első jelszó mező id="Password"
                        //A A második jelszó mező id="ConfirmPassword"
                        $(document).ready(function(){
                            $("#ConfirmPassword").keyup(function(){
                                if ($("#Password").val() != $("#ConfirmPassword").val()) {
                                    $("#msg").html("Jelszavak nem egyezznek!").css("color","red");
                                }else{
                                    $("#msg").html("Jelszavak egyezznek!").css("color","grey");
                                }
                          });
                            $("#Password").keyup(function(){
                                if ($("#Password").val() != $("#ConfirmPassword").val()) {
                                    $("#msg").html("Jelszavak nem egyezznek!").css("color","red");
                                }else{
                                    $("#msg").html("Jelszavak egyezznek!").css("color","grey");
                                }
                          });
                        });
                      </script> 
                      <div class="form-group">
                        <label for="inputFullName">Teljes név</label>
                        <input value="Zóth Toli" name="uFullName" type="text" class="form-control" id="inputFullName" placeholder="Teljes név" required>
                      </div>
                      <div class="form-group">
                        <label for="inputEmail">E-mail cím</label>
                        <input type="email" name="uEmail" class="form-control" id="inputEmail" aria-describedby="emailHelp" placeholder="Add meg az e-mail címed!" required>
                      </div>
                    <button type="submit" id="btn-sub" class="btn btn-primary mt-2">Submit</button><br>
                    <label class="mt-2" id="err"></label>
                  </form>