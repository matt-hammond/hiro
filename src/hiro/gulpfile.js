/// <binding Clean='clean' />

var gulp = require("gulp"),
  rimraf = require("rimraf"),
  fs = require("fs"),
  sass = require("gulp-sass");


eval("var project = " + fs.readFileSync("./project.json"));

var paths = {
  bower: "./bower_components/",
  lib: "./" + project.webroot + "/assets/lib/"
};

gulp.task("clean", function (cb) {
  rimraf(paths.lib, cb);
});

gulp.task("copy", ["clean"], function () {
  var bower = {
    "bootstrap": "bootstrap/dist/**/*.{js,map,css,ttf,svg,woff,eot}",
    "bootstrap-touch-carousel": "bootstrap-touch-carousel/dist/**/*.{js,css}",
    "hammer.js": "hammer.js/hammer*.{js,map}",
    "jquery": "jquery/jquery*.{js,map}",
    "jquery-validation": "jquery-validation/jquery.validate.js",
    "jquery-validation-unobtrusive": "jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"
  }

  for (var destinationDir in bower) {
    gulp.src(paths.bower + bower[destinationDir])
      .pipe(gulp.dest(paths.lib + destinationDir));
  }
});


gulp.task("sass-compile", function () {
    gulp.src("./assets/sass/*.scss")
        .pipe(sass({ includePaths: ["./bower_components/boostrap-sass/assets/stylesheets/"] }))
        .pipe(gulp.dest("./wwwroot/assets/css"));

    gulp.src("./bower_components/boostrap-sass/assets/fonts/bootstrap/*.*")
    .pipe(gulp.dest("./wwwroot/assets/fonts"));
    gulp.src("./bower_components/boostrap-sass/assets/javascripts/bootstrap.min.js")
        .pipe(gulp.dest("./wwwroot/assets/js"));
});
