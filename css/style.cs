/* BODY */
* {
  margin: 0;
  padding: 0;
}

body {
  @import url("https://fonts.googleapis.com/css2?family=Inter:wght@700&family=Poppins&display=swap");
  font-family: "Inter", sans-serif;
  font-family: "Poppins", sans-serif;
}

body {
  background-image: url(../imagenes/wallpaper.jpg);
  background-attachment: fixed;
  background-size: cover;
}

/* HEADER */
header {
  position: fixed;
  display: flex;
  height: 70px;
  width: 100%;
  background-color: rgba(0, 0, 0, 0.856);
  justify-content: space-between;
  align-items: center;
  padding: 0px 40px 0px 10px;
  z-index: 1;
}
header .logo-png {
  height: 70px;
  justify-content: center;
  margin-left: 5px;
  margin-top: 2px;
}
header nav a {
  text-decoration: none;
  color: white;
  font-size: 15px;
  font-weight: 500;
  padding-right: 30px;
  transition: 0.5s;
}
header nav a:hover {
  color: rgb(59, 92, 163);
}

@media screen and (max-width: 600px) {
  header {
    display: flex;
    justify-content: space-around;
    transition: 1s;
  }
  header nav a {
    font-size: 14px;
    padding: 0px 5px;
    transition: 1s;
  }
}
/* INDEX - PANTALLA PRINCIPAL */
.pantalla-principal {
  padding: 300px 400px 200px 150px;
}

.pantalla-principal {
  display: grid;
  border: transparent;
  padding: 350px 0px 250px 150px;
}
.pantalla-principal h1 {
  font-size: 70px;
  font-weight: 600;
  display: inline;
  color: white;
}
.pantalla-principal ul p {
  color: rgb(154, 179, 216);
  font-weight: 600;
  font-size: 15px;
  margin-top: -30px;
  margin-left: -31px;
  display: flex;
}
.pantalla-principal .servicio a {
  text-decoration: none;
  color: white;
  background-color: rgba(78, 78, 78, 0.295);
  padding: 15px 25px;
  margin-top: -120px;
  margin-right: 15px;
  font-size: 12px;
}
.pantalla-principal .servicio a:hover {
  color: rgb(59, 92, 163);
  transition: 0.5s;
}

.video-reel {
  display: grid;
  border: transparent;
  justify-content: center;
  margin-top: 150px;
  margin-bottom: 200px;
  transition: 0.5s;
}

@media screen and (max-width: 700px) {
  .pantalla-principal {
    display: grid;
    text-align: center;
    padding: 250px 0px 10px;
  }
  .pantalla-principal h1 {
    font-size: 40px;
    transition: 1s;
  }
  .pantalla-principal .servicio {
    display: flex;
    border: transparent;
    justify-content: center;
    align-items: center;
    text-align: center;
    margin-top: 10px;
  }
  .pantalla-principal ul p {
    display: grid;
    text-align: center;
  }
  .video-reel {
    position: relative;
    padding-bottom: 70%;
    padding-top: 0px;
    height: 0;
    overflow: hidden;
    margin-bottom: 0;
  }
  .video-reel iframe {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
  }
}
@media screen and (min-width: 701px) {
  h1 {
    transition: 1s;
  }
}
/*NOSOTROS*/
.quienes-somos-container {
  display: grid;
  border: transparent;
  padding: 300px 90px 200px 100px;
}
.quienes-somos-container .titulo-nosotros {
  font-size: 70px;
  font-weight: 800;
  color: white;
}
.quienes-somos-container .texto-nosotros {
  display: grid;
  color: white;
  padding: 40px 0px;
  font-size: 15px;
  font-style: oblique;
}
.quienes-somos-container .titulo-que-hacemos {
  display: grid;
  width: 270px;
  text-align: left;
  border: transparent;
  color: white;
  font-size: 30px;
  padding: 10px 10px;
}
.quienes-somos-container .texto-que-hacemos {
  display: grid;
  color: white;
  font-size: 15px;
  padding-top: 20px;
  padding-bottom: 5px;
  font-style: oblique;
}

@media screen and (max-width: 650px) {
  .quienes-somos-container {
    text-align: left;
    padding: 300px 50px 200px;
    transition: 1s;
  }
  .titulo-nosotros {
    font-size: 50px;
    transition: 1s;
  }
}
@media screen and (min-width: 651px) {
  .quienes-somos-container {
    transition: 1s;
  }
  .titulo-nosotros {
    transition: 1s;
  }
}
/* PROYECTOS */
.titulo-proyectos {
  display: flex;
  text-align: center;
  justify-content: center;
  align-items: center;
  padding-top: 120px;
  padding-bottom: 50px;
  font-size: 50px;
  color: white;
  transition: 1s;
}

#carouselExampleIndicators {
  display: grid;
  margin: 20%;
  width: 60%;
  margin-top: 10px;
  margin-bottom: 0px;
  z-index: 0;
}
#carouselExampleIndicators:hover {
  box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
  transition: 0.5s;
}

.row {
  border: transparent;
  margin-top: 50px;
  margin-bottom: 250px;
}
.row .col {
  padding: 50px 2px 20px 2px;
  margin: 10px 0px;
}
.row .col iframe {
  box-shadow: 0 5px 20px rgba(0, 0, 0, 0.781);
}
.row .col iframe:hover {
  box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
  transform: scale(1.1);
  transition: 0.5s;
}
.row .col h2 {
  font-size: 24px;
  font-weight: 600;
  margin-top: 23px;
  color: white;
  text-shadow: 0 5px 15px rgba(0, 0, 0, 0.781);
}

.mas-contenido {
  display: flex;
  justify-content: center;
  font-size: 40px;
  text-align: center;
  color: white;
  transition: 1s;
}

.proyecto-boton {
  display: flex;
  justify-content: center;
  padding: 60px 0px 250px;
}
.proyecto-boton a {
  text-decoration: none;
  color: black;
  background-color: white;
  padding: 15px 20px;
}
.proyecto-boton a:hover {
  background-color: rgb(80, 52, 105);
  color: white;
  transition: 0.5s;
}

@media screen and (max-width: 600px) {
  .titulo-proyectos {
    font-size: 30px;
    transition: 1s;
  }
  #carouselExampleIndicators {
    display: grid;
    margin: 10%;
    width: 80%;
    margin-top: 10px;
    margin-bottom: 150px;
    z-index: 0;
    transition: 1s;
    box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
  }
  .videos-container .row, .videos-container .col {
    margin: 0px 0px 90px 0px;
    width: 100%;
  }
  .videos-container .col iframe {
    box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
    transform: none;
  }
  .videos-container .col h2 {
    font-size: 15px;
    font-style: italic;
  }
  .videos-container:hover {
    box-shadow: none;
  }
  .videos-container iframe {
    box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
  }
  .mas-contenido {
    padding: 0px 18px;
    font-size: 15px;
  }
  .proyecto-boton a {
    padding: 15px 20px;
    font-size: 13px;
    margin-top: -30px;
  }
}
/* GRUPO TRABAJO */
.grupo-de-trabajo h2 {
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  padding-top: 120px;
  font-size: 50px;
  color: white;
  transition: 1s;
}

.main {
  display: flex;
  align-items: center;
  justify-content: center;
  min-height: 70vh;
  margin-right: 60px;
  transition: 1s;
}

.tarjeta {
  position: relative;
  width: 260px;
  height: 450px;
  background-color: rgba(0, 0, 0, 0.856);
  border-radius: 5px;
  overflow: hidden;
  transition: 0.3s;
}
.tarjeta:hover {
  box-shadow: 0 5px 15px rgba(209, 174, 255, 0.644);
  transform: translatey(-15px);
}
.tarjeta .cabecera {
  height: 130px;
  width: 100%;
  position: relative;
}
.tarjeta .cabecera .img {
  width: 150px;
  height: 150px;
  position: absolute;
  padding: 0px;
  border-radius: 50%;
  bottom: -30;
  top: 30%;
  left: 50%;
  transform: translate(-50%);
}
.tarjeta .cabecera .img img {
  width: 100%;
  height: 100%;
  border-radius: 50%;
}
.tarjeta .descripcion {
  height: 200px;
  padding: 80px 20px;
  border-bottom: solid 1px rgba(6, 74, 76, 0.18);
  color: white;
  text-align: center;
}
.tarjeta .descripcion h3 {
  font-size: 20px;
  color: white;
}
.tarjeta .descripcion h4 {
  color: white;
  margin-top: 5px;
  font-style: italic;
  font-size: 13px;
}
.tarjeta .descripcion p {
  margin-top: 10px;
  font-size: 12px;
}

.perfil {
  width: 5px;
  font-family: Arial, Helvetica, sans-serif;
  font-weight: 600;
  text-decoration: none;
  background-color: rgba(255, 255, 255, 0.788);
  color: black;
  border-radius: 5px;
  padding: 10px 40px;
}
.perfil:hover {
  background-color: rgb(80, 52, 105);
  color: white;
  transition: 0.3s;
}

@media screen and (max-width: 600px) {
  .grupo-de-trabajo h2 {
    font-size: 27px;
    transition: 1s;
  }
  .main {
    display: grid;
    margin: 3px;
    margin-bottom: 80px;
    align-items: center;
    justify-items: center;
    transition: 1s;
  }
  .tarjeta {
    border: 1px solid rgba(209, 174, 255, 0.644);
  }
}
/*SERVICIOS*/
.titulo-servicios {
  display: flex;
  font-size: 50px;
  padding-top: 120px;
  justify-content: center;
  color: white;
  transition: 1s;
}

.servicios-container {
  margin-top: 200px;
  margin-bottom: 200px;
}
.servicios-container h3 {
  color: white;
}

.iconos {
  display: flex;
  border: transparent;
  padding: 20px 220px;
  justify-content: space-around;
  align-items: center;
  transition: 1s;
}
.iconos .img-1 {
  display: grid;
  border: transparent;
}
.iconos .img-1:hover {
  transform: scale(1.2);
  transition: 0.3s;
}
.iconos .icono-text-1 {
  display: grid;
  border: transparent;
  text-align: center;
  padding-right: 17px;
  padding-top: 20px;
}
.iconos .img-2 {
  display: grid;
  border: transparent;
  justify-items: center;
}
.iconos .img-2:hover {
  transform: scale(1.2);
  transition: 0.3s;
}
.iconos .icono-text-2 {
  display: grid;
  border: transparent;
  text-align: center;
  padding-top: 20px;
}
.iconos .img-3 {
  display: grid;
  border: transparent;
}
.iconos .img-3:hover {
  transform: scale(1.2);
  transition: 0.3s;
}
.iconos .icono-text-3 {
  display: grid;
  border: transparent;
  text-align: center;
  padding-top: 20px;
}

.texto-servicios {
  background-color: rgba(33, 8, 56, 0.438);
  color: white;
  margin-top: 340px;
  margin-bottom: 120px;
  padding: 150px 200px 150px;
  font-size: 30px;
  text-align: center;
  justify-content: center;
}

@media screen and (max-width: 950px) {
  .titulo-servicios {
    display: flex;
    text-align: center;
    font-size: 30px;
    transition: 1s;
  }
  .texto-servicios {
    margin-top: 0px;
    margin-bottom: 0px;
  }
  .iconos {
    display: grid;
    border: transparent;
    margin-top: -80px;
    transition: 1s;
  }
  .iconos .img-1 {
    padding-bottom: 70px;
    transition: 1s;
  }
  .iconos .img-2 {
    padding-bottom: 70px;
    transition: 1s;
  }
  .iconos .img-3 {
    padding-bottom: 70px;
    transition: 1s;
  }
  .texto-servicios {
    background-color: rgba(33, 8, 56, 0.438);
    color: white;
    margin-top: 50px;
    margin-bottom: 0px;
    padding: 150px 50px 150px;
    font-size: 20px;
    text-align: center;
    justify-content: center;
    transition: 1s;
  }
}
/* FOOTER */
.footer-container {
  min-height: 150px;
  width: 100%;
  display: flex;
  justify-content: space-around;
  align-items: center;
  background-color: rgba(0, 0, 0, 0.856);
}

footer h3 {
  color: rgb(154, 179, 216);
  margin-bottom: 15px;
  font-style: bold;
  font-size: 16px;
}
footer p {
  color: white;
  font-size: 13px;
  border: transparent;
}
footer img {
  height: 100px;
}
footer h4 {
  display: grid;
  margin-top: 0px;
  font-size: 12px;
  color: white;
}

/* comunicate */
.comunicate {
  display: grid;
  border: transparent;
  margin-top: 10px;
}

.medios {
  display: flex;
  align-items: center;
  border: transparent;
  margin-bottom: -10px;
}

.medios2 {
  display: flex;
  align-items: center;
}

.logo-whatsapp, .logo-gmail {
  display: flex;
  height: 20px;
  margin-right: 12px;
  margin-bottom: 15px;
}

/* logo footer con texto */
.footer-logo {
  border: transparent;
  text-align: center;
  margin-bottom: 3px;
}

/* Derechos reservados */
.derechos-reservados {
  display: flex;
  text-align: center;
  justify-content: center;
  justify-items: center;
  align-items: center;
  margin-top: 15px;
  border: transparent;
}

@media screen and (max-width: 700px) {
  .comunicate, .logo-footer, .derechos-reservados {
    display: flex;
    flex-direction: column;
  }
  .footer-logo {
    padding: 80px 20px 35px;
    order: -1;
  }
  h4 {
    font-size: 15px;
    font-style: oblique;
  }
  .footer-container {
    height: 450px;
    display: grid;
    justify-items: center;
  }
  .logo-footer {
    display: flex;
    height: 150px;
    width: 150px;
  }
  .footer-logo {
    margin: -100px 0px -100px;
  }
  .derechos-reservados {
    margin-top: -60px;
    text-align: center;
    justify-content: center;
    align-items: center;
  }
  .medios, .medios2, .comunicate {
    display: flex;
    align-items: center;
    justify-content: center;
  }
}

/*# sourceMappingURL=style.cs.map */
