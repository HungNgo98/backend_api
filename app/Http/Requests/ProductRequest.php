<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Contracts\Validation\Validator;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Http\Response;


class ProductRequest extends FormRequest
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
            'name_product' => 'required|alpha_num',
            'img' => 'required',
            'price' => 'required|numeric',
        ];
    }


    public function failedValidation(Validator $validator)
{
    throw new HttpResponseException(
        response()->json($validator->errors()->toArray(), Response::HTTP_BAD_REQUEST)
    );
}

}
