<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});

Route::get('getall',[App\Http\Controllers\UserController::class,'getAllUser']);
Route::post('create',[App\Http\Controllers\UserController::class,'createUser']);
Route::post('update',[App\Http\Controllers\UserController::class,'updateUser']);
Route::delete('delete',[App\Http\Controllers\UserController::class,'deleteUser']);
