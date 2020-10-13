using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Application.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OneHundredDays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day001 = table.Column<bool>(nullable: false),
                    Day002 = table.Column<bool>(nullable: false),
                    Day003 = table.Column<bool>(nullable: false),
                    Day004 = table.Column<bool>(nullable: false),
                    Day005 = table.Column<bool>(nullable: false),
                    Day006 = table.Column<bool>(nullable: false),
                    Day007 = table.Column<bool>(nullable: false),
                    Day008 = table.Column<bool>(nullable: false),
                    Day009 = table.Column<bool>(nullable: false),
                    Day010 = table.Column<bool>(nullable: false),
                    Day011 = table.Column<bool>(nullable: false),
                    Day012 = table.Column<bool>(nullable: false),
                    Day013 = table.Column<bool>(nullable: false),
                    Day014 = table.Column<bool>(nullable: false),
                    Day015 = table.Column<bool>(nullable: false),
                    Day016 = table.Column<bool>(nullable: false),
                    Day017 = table.Column<bool>(nullable: false),
                    Day018 = table.Column<bool>(nullable: false),
                    Day019 = table.Column<bool>(nullable: false),
                    Day020 = table.Column<bool>(nullable: false),
                    Day021 = table.Column<bool>(nullable: false),
                    Day022 = table.Column<bool>(nullable: false),
                    Day023 = table.Column<bool>(nullable: false),
                    Day024 = table.Column<bool>(nullable: false),
                    Day025 = table.Column<bool>(nullable: false),
                    Day026 = table.Column<bool>(nullable: false),
                    Day027 = table.Column<bool>(nullable: false),
                    Day028 = table.Column<bool>(nullable: false),
                    Day029 = table.Column<bool>(nullable: false),
                    Day030 = table.Column<bool>(nullable: false),
                    Day031 = table.Column<bool>(nullable: false),
                    Day032 = table.Column<bool>(nullable: false),
                    Day033 = table.Column<bool>(nullable: false),
                    Day034 = table.Column<bool>(nullable: false),
                    Day035 = table.Column<bool>(nullable: false),
                    Day036 = table.Column<bool>(nullable: false),
                    Day037 = table.Column<bool>(nullable: false),
                    Day038 = table.Column<bool>(nullable: false),
                    Day039 = table.Column<bool>(nullable: false),
                    Day040 = table.Column<bool>(nullable: false),
                    Day041 = table.Column<bool>(nullable: false),
                    Day042 = table.Column<bool>(nullable: false),
                    Day043 = table.Column<bool>(nullable: false),
                    Day044 = table.Column<bool>(nullable: false),
                    Day045 = table.Column<bool>(nullable: false),
                    Day046 = table.Column<bool>(nullable: false),
                    Day047 = table.Column<bool>(nullable: false),
                    Day048 = table.Column<bool>(nullable: false),
                    Day049 = table.Column<bool>(nullable: false),
                    Day050 = table.Column<bool>(nullable: false),
                    Day051 = table.Column<bool>(nullable: false),
                    Day052 = table.Column<bool>(nullable: false),
                    Day053 = table.Column<bool>(nullable: false),
                    Day054 = table.Column<bool>(nullable: false),
                    Day055 = table.Column<bool>(nullable: false),
                    Day056 = table.Column<bool>(nullable: false),
                    Day057 = table.Column<bool>(nullable: false),
                    Day058 = table.Column<bool>(nullable: false),
                    Day059 = table.Column<bool>(nullable: false),
                    Day060 = table.Column<bool>(nullable: false),
                    Day061 = table.Column<bool>(nullable: false),
                    Day062 = table.Column<bool>(nullable: false),
                    Day063 = table.Column<bool>(nullable: false),
                    Day064 = table.Column<bool>(nullable: false),
                    Day065 = table.Column<bool>(nullable: false),
                    Day066 = table.Column<bool>(nullable: false),
                    Day067 = table.Column<bool>(nullable: false),
                    Day068 = table.Column<bool>(nullable: false),
                    Day069 = table.Column<bool>(nullable: false),
                    Day070 = table.Column<bool>(nullable: false),
                    Day071 = table.Column<bool>(nullable: false),
                    Day072 = table.Column<bool>(nullable: false),
                    Day073 = table.Column<bool>(nullable: false),
                    Day074 = table.Column<bool>(nullable: false),
                    Day075 = table.Column<bool>(nullable: false),
                    Day076 = table.Column<bool>(nullable: false),
                    Day077 = table.Column<bool>(nullable: false),
                    Day078 = table.Column<bool>(nullable: false),
                    Day079 = table.Column<bool>(nullable: false),
                    Day080 = table.Column<bool>(nullable: false),
                    Day081 = table.Column<bool>(nullable: false),
                    Day082 = table.Column<bool>(nullable: false),
                    Day083 = table.Column<bool>(nullable: false),
                    Day084 = table.Column<bool>(nullable: false),
                    Day085 = table.Column<bool>(nullable: false),
                    Day086 = table.Column<bool>(nullable: false),
                    Day087 = table.Column<bool>(nullable: false),
                    Day088 = table.Column<bool>(nullable: false),
                    Day089 = table.Column<bool>(nullable: false),
                    Day090 = table.Column<bool>(nullable: false),
                    Day091 = table.Column<bool>(nullable: false),
                    Day092 = table.Column<bool>(nullable: false),
                    Day093 = table.Column<bool>(nullable: false),
                    Day094 = table.Column<bool>(nullable: false),
                    Day095 = table.Column<bool>(nullable: false),
                    Day096 = table.Column<bool>(nullable: false),
                    Day097 = table.Column<bool>(nullable: false),
                    Day098 = table.Column<bool>(nullable: false),
                    Day099 = table.Column<bool>(nullable: false),
                    Day100 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneHundredDays", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneHundredDays");
        }
    }
}
