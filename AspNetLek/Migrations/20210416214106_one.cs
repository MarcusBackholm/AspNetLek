using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetLek.Migrations
{
    public partial class one : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Organizer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizerMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganizerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Event_Organizer_OrganizerID",
                        column: x => x.OrganizerID,
                        principalTable: "Organizer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttendeeEvent",
                columns: table => new
                {
                    AttendeesID = table.Column<int>(type: "int", nullable: false),
                    JoinedEventsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeEvent", x => new { x.AttendeesID, x.JoinedEventsID });
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Attendee_AttendeesID",
                        column: x => x.AttendeesID,
                        principalTable: "Attendee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeEvent_Event_JoinedEventsID",
                        column: x => x.JoinedEventsID,
                        principalTable: "Event",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeEvent_JoinedEventsID",
                table: "AttendeeEvent",
                column: "JoinedEventsID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_OrganizerID",
                table: "Event",
                column: "OrganizerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeEvent");

            migrationBuilder.DropTable(
                name: "Attendee");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Organizer");
        }
    }
}
