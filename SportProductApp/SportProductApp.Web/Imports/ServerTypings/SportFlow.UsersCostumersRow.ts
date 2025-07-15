namespace SportProductApp.SportFlow {
    export interface UsersCostumersRow {
        Id?: number;
        Username?: string;
        DisplayName?: string;
        Email?: string;
    }

    export namespace UsersCostumersRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'SportFlow.UsersCostumers';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Username = "Username",
            DisplayName = "DisplayName",
            Email = "Email"
        }
    }
}

