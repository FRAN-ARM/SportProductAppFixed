namespace SportProductApp.Places {
    export interface ProvincesRow {
        ProvinceId?: number;
        Name?: string;
    }

    export namespace ProvincesRow {
        export const idProperty = 'ProvinceId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Places.Provinces';
        export const lookupKey = 'Places.Provinces';

        export function getLookup(): Q.Lookup<ProvincesRow> {
            return Q.getLookup<ProvincesRow>('Places.Provinces');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProvinceId = "ProvinceId",
            Name = "Name"
        }
    }
}

