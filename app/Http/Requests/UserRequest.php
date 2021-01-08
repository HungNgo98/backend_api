<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Contracts\Validation\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Response;

class UserRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     *
     * @return bool
     */
    public function authorize()
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array
     */
    public function rules()
    {
        return [
            'name' => 'required|string',
            'sex' => 'required|bool',

            'password' => 'required|min:8|confirmed',
            'password_confirmation' => 'required',
            'email'=>'required|unique:users,email,'.$this->id.',id',


        ];
    }

   public  function   messages (){

        return[
            'name.required'=> 'phai nhap ten',
            'password.required|min:8'=>'mat khau phai co 8 ki tu',

            ];
}

    public function failedValidation(Validator $validator)
    {
        throw new HttpResponseException(
            response()->json($validator->errors()->toArray(), Response::HTTP_BAD_REQUEST)
        );
    }
}
