# Cómo empezar logbook en local y remoto GIT / GITHUB
## _Apuntejos para novatossssshhh_ por [luismateo](https://github.com/luismateo)


abrir un terminal, te lo abrirá en /home = Ctrl+Alt+t
mkdir lucy // crear carpeta origen
cd lucy // te metes dentro
git init // si no lo encuentra, instalar con el comando que te sugiere
ls -la // mira que ha creado una carpeta oculta .git
ls -la .git // explora lo que hay dentro
git config --global user.name "TU_NOMBRE_REAL_o_NICK_DE_GitHub"
git config --global user.email "la cuenta que vas a usar en GitHub"
touch README.md // Describe el proyecto lucy
mkdir images // carpetas para imágenes
cp .... // copia desde Aules el paquete LucesEnElFirmamento
// añade luz-cielo-thumbnail.jpg, luce-cielo.jpg, astronomy101_hk_960.jpg

mkdir code
cp lucy.cs (desde donde lo tengas)
mkdir docs
cp resto de documentos

abres Dillinger.io en Firefox 
editas y guardas algo bonito par lucy en README.md 
// escribes los datos básicos en formato markdown
// recomendable con dillinger.io y lo exportas como Markdown
mv [ruta]archivo.md [ruta]README.md // mueve el documento a README.md
nano .gitignore //añade *.zip para que ignore los comprimidos

git add * // (git add --all) Para añadir todos los cambios y archivos al HEAD
git status // Muestra el área de preparación
git commit -m "Primera confirmación" // Primer commit para poder subirlo al remote

git remote add origin <> // origin, puedes poner otro nombre
git push --set-upstream origin master // Haces push (lo mandas al repositorio remoto)

Si te da algún error y te sale que necesitas hacer pull, que lo dudo si está totalmente vacío tu repositorio remoto, entonces usa:
git pull origin

5.- Comprueba que todo este cargado en el repositorio remoto.
Con eso deberías poder sincronizar tus repositorios y haber podido subir sin problemas los archivos locales.
