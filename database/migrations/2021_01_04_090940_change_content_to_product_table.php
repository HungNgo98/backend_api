<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class ChangeContentToProductTable extends Migration
{
    public function up()
    {
        Schema::table('product', function (Blueprint $table) {
            $table->renameColumn('content', 'contents');
        });
    }

    public function down()
    {
        Schema::table('product', function (Blueprint $table) {
            $table->renameColumn('contents', 'content');
        });
    }
}
