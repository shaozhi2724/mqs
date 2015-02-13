/*
 *	Build By: Codey Object Relation Mapping
 *	Build Data: 2013-07-19 19:48:09
 *	Build Type: RelationType
 *	Description: All entity of relations.
*/

using System;
using ORMSCore;
using DQS.Module.Entities;

namespace DQS.Module
{
	public class RelationType
	{
        /// <summary>
        /// 子：ATC_RoleMenu，父：SYS_Menu
        /// </summary>
        public static EntityRelation ATC_RoleMenu_Parent_SYS_Menu
        {
            get
            {
                return new EntityRelation("ATC_RoleMenu_Parent_SYS_Menu", EntityType.ATCRoleMenuEntity, ATCRoleMenuEntityFields.MenuCode, EntityType.SYSMenuEntity, SYSMenuEntityFields.MenuCode);
            }
        }

        /// <summary>
        /// 子：ATC_Role，父：ATC_RoleMenu
        /// </summary>
        public static EntityRelation ATC_Role_Parent_ATC_RoleMenu
        {
            get
            {
                return new EntityRelation("ATC_Role_Parent_ATC_RoleMenu", EntityType.ATCRoleEntity, ATCRoleEntityFields.RoleID, EntityType.ATCRoleMenuEntity, ATCRoleMenuEntityFields.RoleID);
            }
        }

        /// <summary>
        /// 子：ATC_User，父：ATC_UserRole
        /// </summary>
        public static EntityRelation ATC_User_Parent_ATC_UserRole
        {
            get
            {
                return new EntityRelation("ATC_User_Parent_ATC_UserRole", EntityType.ATCUserEntity, ATCUserEntityFields.UserID, EntityType.ATCUserRoleEntity, ATCUserRoleEntityFields.UserID);
            }
        }

        /// <summary>
        /// 子：ATC_Role，父：ATC_UserRole
        /// </summary>
        public static EntityRelation ATC_Role_Parent_ATC_UserRole
        {
            get
            {
                return new EntityRelation("ATC_Role_Parent_ATC_UserRole", EntityType.ATCRoleEntity, ATCRoleEntityFields.RoleID, EntityType.ATCUserRoleEntity, ATCUserRoleEntityFields.RoleID);
            }
        }

        /// <summary>
        /// 子：SYS_Menu，父：SYS_Page
        /// </summary>
        public static EntityRelation SYS_Menu_Parent_SYS_Page
        {
            get
            {
                return new EntityRelation("SYS_Menu_Parent_SYS_Page", EntityType.SYSMenuEntity, SYSMenuEntityFields.PageCode, EntityType.SYSPageEntity, SYSPageEntityFields.PageCode);
            }
        }

        /// <summary>
        /// 子：SYS_PageFunction，父：SYS_Function
        /// </summary>
        public static EntityRelation SYS_PageFunction_Parent_SYS_Function
        {
            get
            {
                return new EntityRelation("SYS_PageFunction_Parent_SYS_Function", EntityType.SYSPageFunctionEntity, SYSPageFunctionEntityFields.FunctionCode, EntityType.SYSFunctionEntity, SYSFunctionEntityFields.FunctionCode);
            }
        }

        /// <summary>
        /// 子：ATC_RolePage，父：SYS_Function
        /// </summary>
        public static EntityRelation ATC_RolePage_Parent_SYS_Function
        {
            get
            {
                return new EntityRelation("ATC_RolePage_Parent_SYS_Function", EntityType.ATCRolePageEntity, ATCRolePageEntityFields.FunctionCode, EntityType.SYSFunctionEntity, SYSFunctionEntityFields.FunctionCode);
            }
        }

        /// <summary>
        /// 子：ATC_UserRole，父：ATC_RolePage
        /// </summary>
        public static EntityRelation ATC_UserRole_Parent_ATC_RolePage
        {
            get
            {
                return new EntityRelation("ATC_UserRole_Parent_ATC_RolePage", EntityType.ATCUserRoleEntity, ATCUserRoleEntityFields.RoleID, EntityType.ATCRolePageEntity, ATCRolePageEntityFields.RoleID);
            }
        }
	}
}
