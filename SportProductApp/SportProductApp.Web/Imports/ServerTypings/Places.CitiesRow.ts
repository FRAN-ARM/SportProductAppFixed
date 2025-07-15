namespace SportProductApp.Places {
    export interface CitiesRow {
        CityId?: number;
        ProvinceId?: number;
        Name?: string;
        ProvinceName?: string;
    }

    export namespace CitiesRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Places.Cities';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CityId = "CityId",
            ProvinceId = "ProvinceId",
            Name = "Name",
            ProvinceName = "ProvinceName"
        }
    }
}

