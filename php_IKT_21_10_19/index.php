<!DOCTYPE html>
<html lang="hu">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      rel="stylesheet"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
    <script src='https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js'></script>
    <script src='https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js'></script>
    <link rel="stylesheet" href="css/style.css" />
    <script src="js/script.js" defer></script>
    <title>Login</title>
  </head>
  <body>
    <header>
      <nav class="navbar navbar-dark">
        <a class="navbar-brand" href="#">Header</a>
      </nav>
    </header>
    <main>
      <p>hi</p>
      <div class="middle align-right">
        <?php  
          if(isset($_GET["id"]) && $_GET["id"]=='reglap'){
            include('reg.php');
          }
          else{
            include('login.php');
          }
        ?>
      </div>
    </main>
    <footer id="sticky-footer" class="flex-shrink-0 py-4 text-white-50">
      <div class="container text-center">
        <small>Copyright &copy; Az én weblapom</small>
      </div>
    </footer>
  </body>
</html>
