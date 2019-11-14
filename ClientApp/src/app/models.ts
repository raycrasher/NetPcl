export class Result<T> {
    ok:boolean;
    message:string;
    data:T;
}

export class Level {
    id: number;
    name: string;
}

export class Factor {
    id: number;
    name: string;
    levels: Level[];
}

export class TestSheet {
    id: number;
    name: string;
    factors: Factor[];
}

export class TestSuite {
    id: number;
    name: string;
    description: string;
    sheets: TestSheet[] = [];

}