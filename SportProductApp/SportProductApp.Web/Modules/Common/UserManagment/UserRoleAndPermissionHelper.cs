namespace SportProductApp.Modules.Common.UserManagment
{
    using Serenity.Data;
    using SportProductApp.Administration.Entities;
    using System.Data;
    using System.Linq;
    public static class UserRoleAndPermissionHelper
    {
        public static void AssignRoleAndPermission(IDbConnection connection, int userId, string roleName = "Customer", string permissionKey = "Customers:General")
        {
            // Obtener el rol.
            var roleId = connection.Query<int?>(
                "SELECT RoleId FROM Roles WHERE RoleName = @roleName", new { roleName }).FirstOrDefault();

            // Verificamos que el rol exista, y procedemos con la asignacion.
            if (roleId != null)
            {
                // Asignar el rol al usuario si aún no lo tiene
                var alreadyHasRole = connection.Query<int>(
                    "SELECT COUNT(*) FROM UserRoles WHERE UserId = @userId AND RoleId = @roleId",
                    new { userId, roleId }).FirstOrDefault() > 0;

                if (!alreadyHasRole)
                {
                    connection.Insert(new UserRoleRow
                    {
                        UserId = userId,
                        RoleId = roleId.Value
                    });
                }

                // Asignar el permiso si se especificó
                if (!string.IsNullOrWhiteSpace(permissionKey))
                {
                    var alreadyHasPermission = connection.Query<int>(
                        "SELECT COUNT(*) FROM UserPermissions WHERE UserId = @userId AND PermissionKey = @permissionKey",
                        new { userId, permissionKey }).FirstOrDefault() > 0;

                    if (!alreadyHasPermission)
                    {
                        connection.Insert(new UserPermissionRow
                        {
                            UserId = userId,
                            PermissionKey = permissionKey,
                            Granted = true
                        });
                    }
                }
            }
        }
    }
}
