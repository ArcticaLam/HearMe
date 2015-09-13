/// <reference path="scripts/angular.min.js" />
module.exports = function (grunt) {
    // Project configuration.
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        uglify: {
            options : {
                manage: false
            },
            my_target: {
                files: {
                    'build/app.min.js': ['app/**/*.js'],
                    'build/scripts.min.js': [
                        'scripts/angular.min.js',
                        'scripts/jquery-1.11.3.min.js',
                        'scripts/angular-animate.min.js',
                        'scripts/angular-route.min.js',
                        'scripts/bootstrap.min.js' ]
                }
            }
        },
        
        watch: {
            scripts: {
                files: ['app/**/*.js'],
                tasks: ['uglify']
            }
        },
        
        cssmin: {
            target: {
                files: {
                    'build/stylesheets.min.css': ['contents/**/*.css']
                }
            }
        }

    });

    // Load the plugin that provides the "uglify" task.
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-cssmin');

    // Bunling task.
    grunt.registerTask('bundling', ['uglify', 'cssmin', 'watch']);

};