type Res<T> = {
    status: number;
    data?: T;
    message: string;
}

export default class ApiResponse<T> {
    data?: T | null;
    message!: string;
    status!: number;

    constructor(x: Res<T>) {
        if(x.status !== 200) {
            console.error(x.data);
            this.data = null;
            this.message = x.message;
            this.status = x.status;
            return;
        }
        const { data, status } = x;
        this.data = data;
        this.message = "Success";
        this.status = status;
    }
}