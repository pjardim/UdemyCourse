using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace UdemyCourse.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MAKES (name) VALUES ('Make1')");
            migrationBuilder.Sql("INSERT INTO MAKES (name) VALUES ('Make2')");
            migrationBuilder.Sql("INSERT INTO MAKES (name) VALUES ('Make3')");

            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelA', (SELECT ID FROM MAKES WHERE NAME = 'Make1') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelB', (SELECT ID FROM MAKES WHERE NAME = 'Make1') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make1') )");
            
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make2') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make2') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make2') )");
            
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make3') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make3') )");
            migrationBuilder.Sql("INSERT INTO MODELS (name, MakeId) VALUES ('Make1ModelC', (SELECT ID FROM MAKES WHERE NAME = 'Make3') )");
           


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
